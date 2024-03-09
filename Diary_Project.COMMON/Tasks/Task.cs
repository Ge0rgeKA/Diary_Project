using Diary_Project.COMMON.Enums;

namespace Diary_Project.COMMON.Tasks
{
    public class Task : ATask
    {
        Priority Priority { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
