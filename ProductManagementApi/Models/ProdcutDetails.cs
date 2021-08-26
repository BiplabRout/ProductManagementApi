using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementApi.Models
{
    public class ProdcutDetails : IProductDetails
    {
        private ProductDBContext _context;
        public ProdcutDetails(ProductDBContext context)
        {
            this._context = context;
        }
        public Product addProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product deleteProduct(int hsn_no)
        {
            Product product = _context.Products.Find(hsn_no);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return product;
        }

        public IEnumerable<Product> getAllProduct()
        {
           return  _context.Products;
        }

        public Product getProduct(int hsn_no)
        {
            return _context.Products.Find(hsn_no);
        }

        public Product updateProduct(Product product)
        {
            var item = _context.Products.Attach(product);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return product;
        }
    }
}
