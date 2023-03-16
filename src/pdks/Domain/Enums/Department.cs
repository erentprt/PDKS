using Core.Persistence.Repositories;

namespace Domain.Enums;

public class Department:Entity
{

    public string Name { get; set; }
    public string? Description { get; set; }
    
    public ICollection<Employee> Employees { get; set; }
    
    
    
    public Department()
    {
    }

    public Department(int id, string name, string? description) : base(id)
    {
        Name = name;
        Description = description;
    }

    
}