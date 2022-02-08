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
        public void CreateCustomer(Cusomter cusomter)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Cusomter customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cusomter> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Cusomter GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Cusomter customer)
        {
            throw new NotImplementedException();
        }
    }
}
