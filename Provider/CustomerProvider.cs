using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Repository;
using DBSAPI.Model;

namespace DBSAPI.Provider
{
    public class CustomerProvider : ICustomerProvider
    {
        private readonly ICustomer _repo;

        //public ProdRepo _repo = new ProdRepo();
        public CustomerProvider()
        {

        }
        public CustomerProvider(ICustomer repo)
        {
            _repo = repo;
        }
        public Customer AddNewCustomer(Customer C)
        {
            return _repo.AddNewCustomer(C);
        }
      

        public bool CustomerExists(int id)
        {
            bool res = _repo.CustomerExists(id);
            return res;
        }

        public void DeleteCustomer(int id)
        {
            _repo.DeleteCustomer(id);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public virtual Customer GetCustomerById(int id)
        {
            return (_repo.GetCustomerById(id));
        }

        public Customer UpdateCustomer(int id, Customer C)
        {
            _repo.UpdateCustomer(id, C);
            return C;
        }

    }
}
