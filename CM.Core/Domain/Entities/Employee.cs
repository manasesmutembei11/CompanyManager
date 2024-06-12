using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Manager { get; set; }
        public string OfficeLocation { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string BankAccountNumber { get; set; }

        // Optional: Foreign key to the Company entity
        public Guid CompanyId { get; set; }

        // Optional: Navigation property for related Company entity
        public Company Company { get; set; }
    }
}
