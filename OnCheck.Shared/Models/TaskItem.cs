using System.ComponentModel.DataAnnotations.Schema;

namespace OnCheck.Shared.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Difficulty { get; set; } = string.Empty;
    public bool Completed { get; set; } = false;

    // Foreign Key - User
    public int UserId { get; set; }
    public User? User { get; set; }
}
