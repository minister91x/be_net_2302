using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class ProductOrder : IProductOrder
    {
        ProductManager productManager = new ProductManager();
        List<Orders> orders = new List<Orders>();
        public int Buy_Product(int productid, int quantity)
        {
            /// Bước 1 
            if (quantity <= 0 || quantity <= 0)
            {
                return -1;
            }

            var product = productManager.GetProduct(productid);
            if (product == null || product.ProductID <= 0)
            {
                return -2;
            }
            /// Bước 2 
            if (product.Quantity < quantity)
            {
                return -3;
            }


            /// Bước 3
            var total = product.Price * quantity;

            var ordertotal = quantity >= 5 ? total - total * 0.95 : total;

            
            orders.Add(new Orders
            {
                OrderId = Guid.NewGuid().ToString(),
                ProductId = productid,
                Quantity = quantity,
                OrderTotal= ordertotal
            });

            return 1;

        }
    }
}
