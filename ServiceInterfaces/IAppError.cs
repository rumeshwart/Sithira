using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface IAppError
    {
        void AddError(string key, string errorMessage);
        List<Error> GetErrors();
        bool IsValid { get; }
    }
}
