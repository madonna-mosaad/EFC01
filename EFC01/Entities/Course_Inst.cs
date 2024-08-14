using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.Entities
{
    internal class Course_Inst
    {
        public int Id { get; set; } 
        public int? Course_Id {  get; set; }
        public int? Ins_Id {  get; set; }
        public int Evaluate {  get; set; }
    }
}
