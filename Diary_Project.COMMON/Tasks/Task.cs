using Diary_Project.COMMON.Enums;

namespace Diary_Project.COMMON.Tasks
{
    public class Task
    {
        public
        int Id { get; set; }
        string Name { get; set; }
        Priority Priority { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string Comment {  get; set; }
    }
}
