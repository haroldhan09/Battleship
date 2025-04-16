using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battleship.Persistence.Entities;

[Table("User")]
public class User
{
    [Required, Key]
    public Guid Id { get; init; }
    
    [Required, Column(TypeName = "varchar(100)")]
    public required string Email { get; init; }
    
    [Required]
    public required byte[] PasswordHash { get; init; }
    
    [Required, Column(TypeName = "varchar(100)")]
    public required string Name { get; init; }

    public bool IsVerified { get; init; }
    
    public bool IsAdmin { get; init; }
}