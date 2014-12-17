using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Entity;
namespace DAL_EF
{
    public class CourseRepository : ICourseDataAccess
    {
        TestContext context = new TestContext();
        public void AddNew(Course c)
        {
            context.Courses.Add(c);
            context.SaveChanges();
        }
    }
}
