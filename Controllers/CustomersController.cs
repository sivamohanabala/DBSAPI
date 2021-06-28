using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBSAPI.Data;
using DBSAPI.Model;
using DBSAPI.Provider;

namespace DBSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerProvider _provider;
        public CustomersController(ICustomerProvider provider)
        {
            _provider = provider;
        }



        // GET: api/Customers
        [HttpGet]
        public List<Customer> GetCustomers()
        {
            //To get all customer names
            return _provider.GetCustomers();
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {

            return _provider.GetCustomerById(id);


        }


        [HttpPost]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {


            _provider.AddNewCustomer(customer);
            return CreatedAtAction("GetCustomer", new { id = customer.UserId }, customer);
        }


        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutCustomer(int id, Customer customer)
        {

            try
            {
                _provider.UpdateCustomer(id, customer);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_provider.CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

           


        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
           

            _provider.DeleteCustomer(id);
            return NoContent();
        }

        
    }
}
