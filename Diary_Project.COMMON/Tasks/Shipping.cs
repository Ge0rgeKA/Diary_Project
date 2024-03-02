using Diary_Project.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.COMMON.Tasks
{
    public class Shipping : Task
    {
        decimal Price {  get; set; }
        PaymentStatus PaymentStatus { get; set; }
        CarriageStatus CarriageStatus {  get; set; }

        int SupplierId {  get; set; }
        int CarrierId {  get; set; }
        int WarehouseId {  get; set; }
    }
}
