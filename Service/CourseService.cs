using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceInterfaces;
using Entity;
using DALInterfaces;

namespace Service
{
    public class CourseService : ICourseService
    {
        IAppError errors;
        ICourseDataAccess dal;
        public CourseService(IAppError errors,ICourseDataAccess dal)
        {
            this.errors = errors;
            this.dal = dal;
        }
        public void AddNewCourse(Course c)
        {
            if(Validate(c))
            {
                dal.AddNew(c);
            }
            
        }

        public bool Validate(Course c)
        {
            if(c.CourseName=="")
            {
                errors.AddError("CourseName", "Please Enter Course Name");
            }
            return errors.IsValid;
        }
    }
}
