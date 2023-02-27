using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class Path7<T>
    {
        protected static string GetFullPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + typeof(T).Name + ".txt";
        }
    }
}
