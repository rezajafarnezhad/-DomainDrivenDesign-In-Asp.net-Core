using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.UserAgg.Events;

public class UserRegistered : BaseDomainEvent
{
    public long Id { get;private set; }
    public string Email { get; private set; }

    public UserRegistered(long id, string email)
    {
        Id = id;
        Email = email;
    }
}