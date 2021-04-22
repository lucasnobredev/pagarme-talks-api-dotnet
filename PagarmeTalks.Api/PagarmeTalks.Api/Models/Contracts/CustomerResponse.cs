using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagarmeTalks.Api.Models
{
    public class CustomerResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }
    }
}
