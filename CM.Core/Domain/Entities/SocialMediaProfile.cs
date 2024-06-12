using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Domain.Entities
{

    public class SocialMediaProfile
    {
        public Guid Id { get; set; }
        public string Platform { get; set; }
        public string Username { get; set; }
        public string ProfileUrl { get; set; }
        public string Followers { get; set; }
        public string Following { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public DateTime JoinedDate { get; set; }
        public string PostsCount { get; set; }
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
