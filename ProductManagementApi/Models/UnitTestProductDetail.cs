using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementApi.Models
{
    public class UnitTestProductDetail : IProductDetails
    {
        private readonly List<Product> ProductList;
        public UnitTestProductDetail()
        {
            ProductList = new List<Product> {
               new Product{Name="Test",PartNumber="T123",HsnCode=123,Company="Coy",Sgst=9,Igst=9,Mrp=100,PuchaseWithTax=90,PurchaseWithoutTax=60,SellingPrice=98,Description="Test case"},
               new Product{Name="Demo",PartNumber="D456",HsnCode=456,Company="Telco",Sgst=9,Igst=9,Mrp=100,PuchaseWithTax=90,PurchaseWithoutTax=60,SellingPrice=98,Description="Demo case"},

            };
        }
        public Product addProduct(Product product)
        {
            ProductList.Add(product);
            return product;
        }

        public Product deleteProduct(int hsn_no)
        {
            Product p = ProductList.Find(item => item.HsnCode == hsn_no);
            ProductList.Remove(p);
            return p;
        }

        public IEnumerable<Product> getAllProduct()
        {
            return ProductList;
        }

        public Product getProduct(int hsn_no)
        {
            return ProductList.Find(item => item.HsnCode == hsn_no);
        }

        public Product updateProduct(Product product)
        {
            int hsn_no = product.HsnCode ?? 123;
            Product p = ProductList.Find(item => item.HsnCode == hsn_no);
            ProductList.Remove(p);
            ProductList.Add(product);
            return product;
        }
    }
}
