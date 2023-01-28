namespace Domain.SeedWork;

public abstract class Entity
{
    public Guid Id { get; set; }

    protected Entity()
    {

    }

    protected Entity(Guid id)
    {
        Id = id;
    }

    protected void ValidateBusinessRule(IBusinessRule rule)
    {
        if (rule.IsBroke())
        {
            throw new BusinessRuleException(rule);
        }
    }
}
