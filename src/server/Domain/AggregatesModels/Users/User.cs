using Domain.AggregatesModels.Users.Rules;
using Domain.SeedWork;

namespace Domain.AggregatesModels.Users;

public class User : Entity
{
    public string UserName { get; private set; }
    public string Password { get; private set; }

    public static User Create(string userName, string password)
    {
        return new User(userName, password);
    }

    public static User Create(Guid id, string userName, string password)
    {
        return new User(id, userName, password);
    }

    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public User(Guid id, string userName, string password)
        : base(id)
    {
        UserName = userName;
        Password = password;
    }

    public void UpdateUserName(string userName)
    {
        this.ValidateBusinessRule(new ValidateUserName(userName));

        UserName = userName;
    }

    public void UpdatePassword(string password)
    {
        Password = password;
    }
}