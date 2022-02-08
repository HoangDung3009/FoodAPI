using FoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI.Interfaces
{
    public interface ICustomer
    {
        IEnumerable<Cusomter> GetAllCustomers();
        Cusomter GetCustomerById(int id);
        void CreateCustomer(Cusomter customer);
        void UpdateCustomer(Cusomter customer);
        void DeleteCustomer(Cusomter customer);
        bool SaveChanges();
    }
}
