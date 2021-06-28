using DBSAPI.Data;
using DBSAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSAPI.Repository
{
    public class BookingStatusRepo : IBookingStatus
    {

        private readonly CustomerContext _context;
        public BookingStatusRepo()
        {

        }
        public BookingStatusRepo(CustomerContext Context)
        {
            _context = Context;
        }
        public BookingStatus AddBookingStatus(BookingStatus B)
        {
             _context.BookingStatus.Add(B);
            _context.SaveChanges();
            return B;
        }

        public bool BookingStatusExists(int id)
        {
            return _context.BookingStatus.Any(e => e.UserId == id);
        }

        public void DeleteBookingStatus(int id)
        {
            BookingStatus c = _context.BookingStatus.Find(id);

            _context.BookingStatus.Remove(c);

            _context.SaveChanges();
        }

        public List<BookingStatus> GetBookingHistory(int id)
        {
            List<BookingStatus> bookingStatuses = new List<BookingStatus>();
            bookingStatuses = _context.BookingStatus.ToList();

            bookingStatuses = bookingStatuses.Where(x => x.BookingId == id).ToList();
            return bookingStatuses;
        }

        public List<BookingStatus> GetBookingStatus()
        {
            return _context.BookingStatus.ToList();
        }

        public BookingStatus GetBookingStatusById(int id)
        {
            return _context.BookingStatus.Find(id);
        }

        public BookingStatus UpdateBookingStatus(int id, BookingStatus B)
        {
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            _context.Entry(B).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //_context.SaveChanges();
            // _context.Add(B);
            //_context.BookingStatus.Attach(B);
            _context.BookingStatus.Add(B);
            return B;
        }
    }
}
