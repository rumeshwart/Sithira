using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public class AppError : IAppError
    {
        List<Error> errors = new List<Error>();
        public void AddError(string key, string errorMessage)
        {
            errors.Add(new Error(key, errorMessage));
        }

        public List<Error> GetErrors()
        {
            return errors;
        }

        public bool IsValid
        {
            get 
            {  
                if(errors.Count()==0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
