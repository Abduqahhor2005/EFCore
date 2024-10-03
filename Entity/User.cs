using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Entity;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int Age { get; set; }
    public string Gender { get; set; } = null!;
}