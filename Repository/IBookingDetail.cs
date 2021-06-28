using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Model;

namespace DBSAPI.Repository
{
   public interface IBookingDetail
    {
        public List<BookingDetail> GetBookingDetail();
        public BookingDetail GetBookingDetailById(int id);

        public BookingDetail AddBookingDetail(BookingDetail B);

        public void DeleteBookingDetail(int id);
        public BookingDetail UpdateBookingDetail(int id, BookingDetail B);

       
        public bool BookingDetailExists(int id);
    }
}
