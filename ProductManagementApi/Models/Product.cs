using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementApi.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string PartNumber { get; set; }

        [Key]
        public Nullable<int> HsnCode { get; set; }
        public string Company { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> Sgst { get; set; }
        public Nullable<int> Igst { get; set; }
        public Nullable<double> Mrp { get; set; }
        public Nullable<double> PurchaseWithoutTax { get; set; }
        public Nullable<double> PuchaseWithTax { get; set; }
        public Nullable<double> SellingPrice { get; set; }
        public string Description { get; set; }
    }
}
