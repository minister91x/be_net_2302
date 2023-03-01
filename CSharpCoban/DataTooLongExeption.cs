using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    internal class DataTooLongExeption : Exception
    {
        const string erroMessage = "Dữ liệu quá dài";
        public DataTooLongExeption() : base(erroMessage)
        {
        }

    }
}
