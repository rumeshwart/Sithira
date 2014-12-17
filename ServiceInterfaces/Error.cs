using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public class Error
    {
        public Error(string errorid,string errorname)
        {
            this.ErrorID = errorid;
            this.ErrorDescription = errorname;
        }
        public string ErrorID { get; set; }
        public string ErrorDescription { get; set; }
    }
}
