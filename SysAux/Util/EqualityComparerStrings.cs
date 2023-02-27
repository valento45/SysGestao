using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Util
{
    public class EqualityComparerStrings : EqualityComparer<string>
    {
        public EqualityComparerStrings()
        {
            
        }
        public override bool Equals(string x, string y)
        {
            return x.Equals(y);
        }

        public override int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}
