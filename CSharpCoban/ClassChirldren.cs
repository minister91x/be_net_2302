using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class ClassChirldren : ClassParent
    {
        public ClassChirldren()
        {
            Console.WriteLine("ClassChirldren");
        }
        public int ChirldrenID { get; set; }
    }
}
