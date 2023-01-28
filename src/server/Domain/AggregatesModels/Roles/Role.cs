using Domain.SeedWork;

namespace Domain.AggregatesModels.Roles;

public class Role : Entity
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string? Description { get; set; }
    public List<Permission> Permissions { get; set; }

    public static Role Create(string name, string displayName) => new Role(name, displayName);

    public static Role Create(string name, string displayName, string? description = default)
        => new Role(name, displayName, description);

    public Role(string name, string displayName)
    {
        Name = name;
        DisplayName = displayName;
        Permissions = new List<Permission>();
    }

    public Role(string name, string displayName, string? description = default)
    {
        Name = name;
        DisplayName = displayName;
        Description = description;
        Permissions = new List<Permission>();
    }

    public void AddPermission(string name)
    {
        this.AddPermission(Permission.Create(name));
    }

    public void AddPermission(Permission permission)
    {
        this.Permissions.Add(permission);
    }
}
