using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class ClassParent
    {
        public ClassParent()
        {
            Console.WriteLine("ClassParent");
        }
        public int Id { get; set; }
        private string Name { get; set; }
    }
}
