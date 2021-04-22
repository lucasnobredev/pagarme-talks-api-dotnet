using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PagarmeTalks.Api.Models.Contracts
{
    public class CustomerRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Document { get; set; }
        [Required]
        public string DocumentType { get; set; }
    }
}
