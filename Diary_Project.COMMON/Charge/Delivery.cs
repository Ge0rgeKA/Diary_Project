using Diary_Project.COMMON.Enums;

namespace Diary_Project.COMMON.Charge
{
    public class Delivery : ChargeInputModel
    {
        decimal Price {  get; set; }
        PaymentStatus PaymentStatus { get; set; }
        CarriageStatus CarriageStatus {  get; set; }
    }
}
