using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public interface IProductOrder
    {
        int Buy_Product(int productid, int quantity);
    }
}
