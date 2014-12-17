using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALInterfaces
{
    public interface ICourseDataAccess
    {
        void AddNew(Course c);
        
    }
}
