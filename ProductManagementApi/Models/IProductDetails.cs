using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementApi.Models
{
    public interface IProductDetails
    {
        Product getProduct(int hsn_no);
        IEnumerable<Product> getAllProduct();
        Product addProduct(Product product);
        Product deleteProduct(int hsn_no);
        Product updateProduct(Product product);
    }
}
