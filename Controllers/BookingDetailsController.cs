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
    public class BookingDetailsController : ControllerBase
    {

        private readonly IBookingProvider _provider;
        public BookingDetailsController(IBookingProvider provider)
        {
            _provider = provider;
        }


        // GET: api/BookingDetails
        [HttpGet]
        public List<BookingDetail> GetBookingDetail()
        {
            return _provider.GetBookingDetail();
        }

        // GET: api/BookingDetails/5
        [HttpGet("{id}")]
        public ActionResult<BookingDetail> GetBookingDetailById(int id)
        {
            return _provider.GetBookingDetailById(id);
        }

        // PUT: api/BookingDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutBookingDetail(int id, BookingDetail B)
        {
            try
            {
                _provider.UpdateBookingDetail(id, B);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_provider.BookingDetailExists(id))
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

        // POST: api/BookingDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<BookingDetail> PostBookingDetail(BookingDetail B)
        {

            _provider.AddBookingDetail(B);
            return CreatedAtAction("GetBookingDetail", new { id = B.BookingId }, B);
        }

        // DELETE: api/BookingDetails/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBookingDetail(int id)
        {
           
            _provider.DeleteBookingDetail(id);
            return NoContent();
        }

       
    }
}
