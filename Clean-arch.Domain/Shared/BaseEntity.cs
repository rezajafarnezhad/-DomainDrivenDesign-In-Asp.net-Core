using System.ComponentModel.DataAnnotations.Schema;

namespace Clean_arch.Domain.Shared;

public class BaseEntity
{
    public long Id { get;private set; }
    public DateTime CreationDate { get; }

    public BaseEntity()
    {
        CreationDate =DateTime.Now;
    }
}


public class BaseDomainEvent
{
    public DateTime CreationDate { get; protected set; }

    public BaseDomainEvent()
    {
        CreationDate = DateTime.Now;
    }
}

public class AggregateRoot : BaseEntity
{

    private readonly List<BaseDomainEvent> _domainEvents = new List<BaseDomainEvent>();

    [NotMapped]
    public List<BaseDomainEvent> DomainEvents => _domainEvents;

    public void AddDomainEvent(BaseDomainEvent eventItem)
    {
        _domainEvents.Add(eventItem);
    }

    public void RemoveDomainEvent(BaseDomainEvent eventItem)
    {
        _domainEvents?.Remove(eventItem);
    }
}