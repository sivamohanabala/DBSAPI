using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Repository;
using DBSAPI.Model;

namespace DBSAPI.Provider
{
    public interface ICustomerProvider
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);

        public Customer AddNewCustomer(Customer C);

        public void DeleteCustomer(int id);
        public Customer UpdateCustomer(int id, Customer C);


        public bool CustomerExists(int id);
    }
}
