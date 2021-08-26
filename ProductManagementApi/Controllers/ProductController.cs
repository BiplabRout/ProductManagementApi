using Microsoft.AspNetCore.Mvc;
using ProductManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProductManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductDetails _productDetails;
        public ProductController(IProductDetails productDetails)
        {
            this._productDetails = productDetails;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productDetails.getAllProduct();
        }

        
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _productDetails.addProduct(product);
        }
    }
}
