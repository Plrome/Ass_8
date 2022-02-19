using System.ComponentModel;

namespace Ass_8.Models;

public class TaskUpdateModel : TaskCreateModel
{
    [DefaultValue(0)]
    public bool Completed { get; set; }
}