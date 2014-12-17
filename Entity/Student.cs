using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        
        public int ID { get; set; }
        public string StudentName { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        
    }
}
