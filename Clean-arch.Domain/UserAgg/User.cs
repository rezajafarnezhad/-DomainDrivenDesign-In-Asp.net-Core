using Clean_arch.Domain.Shared;
using Clean_arch.Domain.UserAgg.Events;

namespace Clean_arch.Domain.User;

public class User: AggregateRoot
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get;private set; }

    public User( string name, string lastName, string email)
    {
        Name = name;
        LastName = lastName;
        Email = email;
    }

    public static User Register(string email)
    {
        var user =  new User("", "", email);

        user.AddDomainEvent(new UserRegistered(user.Id,user.Email));
        return user;
    }
}