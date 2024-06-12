using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{
    public class FinancialRecord
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }
        public decimal NetIncome { get; set; }
        public string Currency { get; set; }
        public string StatementType { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportType { get; set; }
        public string Auditor { get; set; }
        public string Notes { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
