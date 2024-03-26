using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary_Project.COMMON.Charge;

namespace Diary_Project.BLL.Contracts.Charge
{
    public interface IChargeLogic
    {
        public void Create(ChargeInputModel task);
    }
}
