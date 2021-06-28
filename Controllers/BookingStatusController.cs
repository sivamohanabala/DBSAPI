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
    public class BookingStatusController : ControllerBase
    {
        private readonly IBookingStatusProvider _provider;
        public BookingStatusController(IBookingStatusProvider provider)
        {
            _provider = provider;
        }


      

       
        // GET: api/BookingStatus
        [HttpGet]
        public List<BookingStatus> GetBookingStatus()
        {
            return _provider.GetBookingStatus();
        }

        // GET: api/BookingStatus/5
        [HttpGet("{id}")]
        public ActionResult<BookingStatus> GetBookingStatusById(int id)
        {

            return _provider.GetBookingStatusById(id);
        }

        [HttpGet("BookHistory")]
        public List<BookingStatus> GetBookingHistory(int id)
        {

            return _provider.GetBookingHistory(id);
        }

        // PUT: api/BookingStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutBookingStatus(int id, BookingStatus bookingStatus)
        {
            if (id != bookingStatus.BookingStatusId)
            {
                return BadRequest();
            }

            //_context.Entry(bookingStatus).State = EntityState.Modified;

            try
            {
                // await _context.SaveChangesAsync();
                _provider.UpdateBookingStatus(id, bookingStatus);
                
                
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BookingStatusExists(id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return NoContent();
        }

        // POST: api/BookingStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<BookingStatus> PostBookingStatus(BookingStatus B)
        {
            _provider.AddBookingStatus(B);
          
            return CreatedAtAction("GetBookingStatus", new { id = B.BookingStatusId}, B);
            //_context.BookingStatus.Add(bookingStatus);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetBookingStatus", new { id = bookingStatus.BookingStatusId }, bookingStatus);
        }

        // DELETE: api/BookingStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingStatus(int id)
        {
            //var bookingStatus = await _context.BookingStatus.FindAsync(id);
            //if (bookingStatus == null)
            //{
            //    return NotFound();
            //}

            //_context.BookingStatus.Remove(bookingStatus);
            //await _context.SaveChangesAsync();

            return NoContent();
        }

        //private bool BookingStatusExists(int id)
        //{
        //    return _context.BookingStatus.Any(e => e.BookingStatusId == id);
        //}
    }
}
