using DBSAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSAPI.Provider
{
    public interface IBookingStatusProvider
    {
        public List<BookingStatus> GetBookingStatus();
        public BookingStatus GetBookingStatusById(int id);

        public BookingStatus AddBookingStatus(BookingStatus B);

        public void DeleteBookingStatus(int id);
        public BookingStatus UpdateBookingStatus(int id, BookingStatus B);


        public bool BookingStatusExists(int id);
        public List<BookingStatus> GetBookingHistory(int id);
    }
}
