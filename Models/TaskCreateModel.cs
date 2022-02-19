using System.ComponentModel.DataAnnotations;

namespace Ass_8.Models;

public class TaskCreateModel
{
    [Required, MaxLength(50)]
    public string? Title { get; set; }
    public string? Description { get; set; }
}