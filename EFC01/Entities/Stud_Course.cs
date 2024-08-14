using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.Entities
{
    internal class Stud_Course
    {
        public int Id { get; set; }
        public int? Stud_Id {  get; set; }
        public int? Course_Id { get; set; }
        public double Grade {  get; set; }
    }
}
