using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Tagline { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string RegistrationNumber { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string DUNSNumber { get; set; }
        public DateTime FoundedDate { get; set; }
        public string HeadquartersAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public decimal AnnualRevenue { get; set; }
        public int NumberOfEmployees { get; set; }

        // Optional: Navigation properties for related entities
        public List<Branch> Branches { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }
        public List<PressRelease> PressReleases { get; set; }
        public List<FinancialRecord> FinancialRecords { get; set; }
        public List<PatentTrademark> PatentsTrademarks { get; set; }
        public List<Competitor> Competitors { get; set; }
        public List<SocialMediaProfile> SocialMediaProfiles { get; set; }
        public List<CSRInitiative> CSRInitiatives { get; set; }

        public Company()
        {
            Branches = new List<Branch>();
            Employees = new List<Employee>();
            Products = new List<Product>();
            PressReleases = new List<PressRelease>();
            FinancialRecords = new List<FinancialRecord>();
            PatentsTrademarks = new List<PatentTrademark>();
            Competitors = new List<Competitor>();
            SocialMediaProfiles = new List<SocialMediaProfile>();
            CSRInitiatives = new List<CSRInitiative>();
        }
    }
}
