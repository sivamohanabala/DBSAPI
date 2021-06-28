using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Data;
using DBSAPI.Model;

namespace DBSAPI.Repository
{
    public class BookingDetailRepo : IBookingDetail
    {
        private readonly CustomerContext _context;
       
        public BookingDetailRepo()
        {

        }
        public BookingDetailRepo(CustomerContext Context)
        {
            _context = Context;
        }
        public BookingDetail AddBookingDetail(BookingDetail B)
        {
            _context.BookingDetails.Add(B);
           
            _context.SaveChanges();
           
           
           
            return B;
        }

        public bool BookingDetailExists(int id)
        {
            return _context.BookingDetails.Any(e => e.BookingId == id);
        }

        public void DeleteBookingDetail(int id)
        {
            BookingDetail b = _context.BookingDetails.Find(id);

            _context.BookingDetails.Remove(b);

            _context.SaveChanges();
        }

        public List<BookingDetail> GetBookingDetail()
        {
            return _context.BookingDetails.ToList();
        }

        public BookingDetail GetBookingDetailById(int id)
        {
            return _context.BookingDetails.Find(id);
        }

        public BookingDetail UpdateBookingDetail(int id, BookingDetail B)
        {
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            _context.Entry(B).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return B;
        }
    }
}
