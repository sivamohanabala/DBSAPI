using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Repository;
using DBSAPI.Data;
using DBSAPI.Model;

namespace DBSAPI.Repository
{
    public class CustomerRepo : ICustomer
    {
        private readonly CustomerContext _context;
        public CustomerRepo()
        {

        }
        public CustomerRepo(CustomerContext Context)
        {
            _context = Context;
        }
        public Customer AddNewCustomer(Customer C)
        {
            _context.Customers.Add(C);
            _context.SaveChanges();
            return C;

        }

        public bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.UserId == id);
        }

        public void DeleteCustomer(int id)
        {
            Customer c = _context.Customers.Find(id);

            _context.Customers.Remove(c);

            _context.SaveChanges();

        }

        public List<Customer> GetCustomers()
        {

            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        
         public Customer UpdateCustomer(int id, Customer C)
        {
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            _context.Entry(C).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return C;
        }
    }
}
