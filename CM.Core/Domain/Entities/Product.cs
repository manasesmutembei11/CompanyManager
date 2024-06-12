using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public string SKU { get; set; }
        public string UPC { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Category { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFeatured { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string Location { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
