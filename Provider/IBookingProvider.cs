using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Model;

namespace DBSAPI.Provider
{
    public interface IBookingProvider
    {
        public List<BookingDetail> GetBookingDetail();
        public BookingDetail GetBookingDetailById(int id);

        public BookingDetail AddBookingDetail(BookingDetail C);

        public void DeleteBookingDetail(int id);
        public BookingDetail UpdateBookingDetail(int id, BookingDetail C);


        public bool BookingDetailExists(int id);
    }
}
