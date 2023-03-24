using System;
using System.Collections.Generic;
using System.IO;
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
            string folder = @"C:\Temp\";
            // Filename
            string fileName = "Product.txt";
            // Fullpath. You can direct hardcode it if you like.
            string fullPath = folder + fileName;
            // An array of strings
            string[] authors = new string[products.Count];
            for (int i = 0; i < authors.Length; i++)
            {
                authors[i] = products[i].Name;
            }
            // Write array of strings to a file using WriteAllLines.
            // If the file does not exists, it will create a new file.
            // This method automatically opens the file, writes to it, and closes file
            File.WriteAllLines(fullPath, authors);
            // Read a file
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}
