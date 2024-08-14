using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ins_Id { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
