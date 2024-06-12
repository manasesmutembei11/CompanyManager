using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{

    public class CSRInitiative
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Organizer { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Website { get; set; }
        public string Status { get; set; }
        public string Participants { get; set; }
        public string Impact { get; set; }
        public string Partners { get; set; }
        public string Sponsorships { get; set; }
        public string Budget { get; set; }
        public string Resources { get; set; }
        public string Notes { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
