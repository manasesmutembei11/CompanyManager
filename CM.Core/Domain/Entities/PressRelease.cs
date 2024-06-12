using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{
    public class PressRelease
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string SourceUrl { get; set; }
        public string SourceName { get; set; }
        public string SourceLogoUrl { get; set; }
        public string Tags { get; set; }
        public bool IsFeatured { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
