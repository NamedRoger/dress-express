using Domain.SeedWork;

namespace Domain.AggregatesModels.Users.Rules;

public class ValidateUserName : IBusinessRule
{
    private string _userName;
    public ValidateUserName(string userName)
    {
        _userName = userName;
    }
    public string Message { get => "The userName must be more than 4 characteres"; }

    public bool IsBroke()
    {
        return _userName.Length < 4;
    }
}
