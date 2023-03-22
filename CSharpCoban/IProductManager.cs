using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public interface IProductManager
    {
        void InsertProduct(Product product);
        Product GetProduct(int id);
        int UpdateProuct(int Id,string name,int Total);
        List<Product> GetProucts();
        int Product_Delete(int Id);
        void WriteTextFile(List<Product> products);
    }
}
