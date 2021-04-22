using PagarmeTalks.Api.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagarmeTalks.Api.Models.Entities
{
    public class Customer
    {
        public Customer(CustomerRequest request)
        {
            var random = new Random();
            ExternalId = "cus_" + random.Next(9999999);
            Name = request.Name;
            Email = request.Email;
            Document = request.Document;
            DocumentType = request.DocumentType;
        }

        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }

        public void Update(CustomerRequest request)
        {
            Name = request.Name;
            Email = request.Email;
            Document = request.Document;
            DocumentType = request.DocumentType;
        }
    }
}
