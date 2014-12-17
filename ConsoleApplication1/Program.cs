using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DALInterfaces;
using ServiceInterfaces;
using Service;
using DAL_EF;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourseDataAccess da = new CourseRepository();
            IAppError apperror = new AppError();

            ICourseService serv = new CourseService(apperror,da);
            Course c = new Course();
            c.CourseName = "";
            serv.AddNewCourse(c);

            if(apperror.IsValid)
            {
                Console.WriteLine("Course Added");
            }
            else
            {
                foreach(Error e in apperror.GetErrors())
                {
                    Console.WriteLine(e.ErrorDescription);
                }
            }
            
            Console.ReadLine();
           
        }
    }
}
