using PagarmeTalks.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagarmeTalks.Api.Repositories
{
    public class CustomerRepository
    {
        private static IList<Customer> customers = new List<Customer>();

        public Customer GetById(string id)
        {
            return customers.FirstOrDefault(x => x.ExternalId == id);
        }

        public IList<Customer> GetAll()
        {
            return customers;
        }

        public bool Save(Customer customer)
        {
            customers.Add(customer);
            return true;
        }

        public bool Update(Customer customer)
        {
            var customerToDelete = customers.FirstOrDefault(x => x.ExternalId == customer.ExternalId);
            customers.Remove(customerToDelete);
            customers.Add(customer);

            return true;
        }

        public bool Delete(string id)
        {
            var customerToDelete = customers.FirstOrDefault(x => x.ExternalId == id);
            customers.Remove(customerToDelete);
            return true;
        }
    }
}
