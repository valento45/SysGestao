using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Exceptions
{
    public class QueryException : Exception
    {
        public QueryException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
