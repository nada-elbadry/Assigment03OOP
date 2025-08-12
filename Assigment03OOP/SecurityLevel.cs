using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03OOP
{// Security Levels Enum
    [Flags]
   public enum SecurityLevel
    {
        None = 0,
        Guest = 1 << 0,       // 1
        Developer = 1 << 1,   // 2
        Secretary = 1 << 2,   // 4
        DBA = 1 << 3,         // 8
        FullAccess = Guest | Developer | Secretary | DBA
    }
}
