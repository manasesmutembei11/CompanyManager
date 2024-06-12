using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{
    public class PatentTrademark
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Owner { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string ApplicationNumber { get; set; }
        public string ApplicationDate { get; set; }
        public string Agent { get; set; }
        public string LegalStatus { get; set; }
        public string Notes { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
