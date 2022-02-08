using FoodAPI.Interfaces;
using FoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI.Services
{
    public class CustomerService : ICustomer
    {
        private readonly FoodDBContext _context;
        public CustomerService(FoodDBContext context)
        {
            this._context = context;
        }
        public void CreateCustomer(Cusomter customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _context.Cusomters.Add(customer);
        }

        public void DeleteCustomer(Cusomter customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _context.Cusomters.Remove(customer);
        }

        public IEnumerable<Cusomter> GetAllCustomers()
        {
            return _context.Cusomters.ToList();
        }

        public Cusomter GetCustomerById(int id)
        {
            return _context.Cusomters.FirstOrDefault(x => x.CustomerId == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Cusomter customer)
        {
            //Do nothing
        }
    }
}
