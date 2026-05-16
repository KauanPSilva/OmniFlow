namespace OmniFlow.Domain.Entities;

public class User: BaseEntity
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required Guid RoleId { get; set; }
    public Role Role { get; set; }
}