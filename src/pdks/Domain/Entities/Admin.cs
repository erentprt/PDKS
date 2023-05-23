using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Admin:Entity
{
    public string Email { get; set; }
    public string Password { get; set; }
}