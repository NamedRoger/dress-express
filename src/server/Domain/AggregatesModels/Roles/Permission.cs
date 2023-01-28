using Domain.SeedWork;

namespace Domain.AggregatesModels.Roles;

public class Permission : Entity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public static Permission Create(string name) => new Permission(name);

    public Permission(string name)
    {
        Name = name;
    }
}
