using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductManagementApi.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product { Name= "Battery Cut",PartNumber= "RBCSBC",HsnCode= 85365090,Company="BOSCH",Qty=30,Sgst=9,Igst=9,Mrp= 866.00,PuchaseWithTax=750.00,PurchaseWithoutTax=650.00,SellingPrice=850.00,Description= "RBCSBC(BATTERY CUT)" },
                new Product { Name = "Bearing", PartNumber = "TX 88512WOS-AL", HsnCode = 85365060, Company = "TELCO", Qty = 10, Sgst = 9, Igst = 9, Mrp = 1600.00, PuchaseWithTax = 1200.00, PurchaseWithoutTax = 1100.00, SellingPrice = 1550.00, Description = "TX 88512WOS-AL (Bearing)" }
                );
        }
    }
}
