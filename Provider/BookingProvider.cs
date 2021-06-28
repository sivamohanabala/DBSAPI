using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBSAPI.Model;
using DBSAPI.Repository;

namespace DBSAPI.Provider
{
    public class BookingProvider : IBookingProvider
    {
        private readonly IBookingDetail _bookrepo;
        public BookingProvider()
        {

        }
        public BookingProvider(IBookingDetail bookrepo)
        {
            _bookrepo = bookrepo;
        }
        public BookingDetail AddBookingDetail(BookingDetail B)
        {
            return _bookrepo.AddBookingDetail(B);
        }

        public bool BookingDetailExists(int id)
        {
            bool res = _bookrepo.BookingDetailExists(id);
            return res;
        }

        public void DeleteBookingDetail(int id)
        {
            _bookrepo.DeleteBookingDetail(id);
        }

        public List<BookingDetail> GetBookingDetail()
        {
            return _bookrepo.GetBookingDetail();
        }

        public virtual BookingDetail GetBookingDetailById(int id)
        {
            return _bookrepo.GetBookingDetailById(id);
        }

        public BookingDetail UpdateBookingDetail(int id, BookingDetail B)
        {
            _bookrepo.UpdateBookingDetail(id, B);
            return B;
        }

    }
}
