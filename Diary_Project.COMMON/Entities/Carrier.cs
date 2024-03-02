using Diary_Project.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_Project.COMMON.Entities
{
    public class Carrier
    {
        int Id { get; set; }
        string Name { get; set; }
        Priority Reliability { get; set; }
        string Comment { get; set; }
    }
}
