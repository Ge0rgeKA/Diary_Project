using Diary_Project.COMMON.Enums;

namespace Diary_Project.COMMON.Charge
{
    public class ChargeInputModel : ACharge
    {
        Priority Priority { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
