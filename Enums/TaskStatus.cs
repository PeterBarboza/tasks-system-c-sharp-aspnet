using System.ComponentModel;

namespace TasksSystem.Enums
{
    public enum TaskStatus
    {
        [Description("A fazer")]
        Pending = 1,
        [Description("Em andamento")]
        InProgress = 2,
        [Description("Concluído")]
        Finished = 3,
    }
}