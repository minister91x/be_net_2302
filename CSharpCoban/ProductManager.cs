using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class ProductManager : IProductManager
    {
        public List<Product> lstproducts = new List<Product>();
        public Product GetProduct(int id)
        {
            return lstproducts.Where(s => s.ProductID == id).FirstOrDefault();
        }

        public List<Product> GetProucts()
        {
            return lstproducts;
        }

        public void InsertProduct(Product product)
        {
            lstproducts.Add(product);
        }

        public int Product_Delete(int Id)
        {
            var product = new Product();
            //var product = lstproducts.Where(s => s.ProductID == Id).FirstOrDefault();
            //if(product==null || product.ProductID < 0)
            //{
            //    return -1;
            //}

            if (lstproducts != null && lstproducts.Count > 0)
            {
                foreach (var item in lstproducts)
                {
                    if (item.ProductID == Id)
                    {
                        product = item;
                    }
                }
            }

            if (product == null || product.ProductID < 0)
            {
                return -1;
            }
            lstproducts.Remove(product);

            return 1;
        }

        public int UpdateProuct(int Id, string name, int Total)
        {
            var product = new Product();
            if (lstproducts != null && lstproducts.Count > 0)
            {
                foreach (var item in lstproducts)
                {
                    if (item.ProductID == Id)
                    {
                        product = item;
                    }
                }
            }

            if (product == null || product.ProductID < 0)
            {
                return -1;
            }

            product.Name = name;
            product.Total = Total;
            return 1;
        }

        public void WriteTextFile(List<Product> products)
        {

        }
    }
}
