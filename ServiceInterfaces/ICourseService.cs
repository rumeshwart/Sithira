using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace ServiceInterfaces
{
    public interface ICourseService
    {
        void AddNewCourse(Course c);
        bool Validate(Course c);
    }
}
