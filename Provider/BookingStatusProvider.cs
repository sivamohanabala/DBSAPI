using DBSAPI.Model;
using DBSAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBSAPI.Provider
{
    public class BookingStatusProvider : IBookingStatusProvider
    {

        //private readonly IBookingDetail _bookrepo;
        //public BookingProvider()
        //{

        //}
        //public BookingProvider(IBookingDetail bookrepo)
        //{
        //    _bookrepo = bookrepo;
        //}
        

        private readonly IBookingStatus _bookStatusRepo;

        public BookingStatusProvider()
        { }

        public BookingStatusProvider(IBookingStatus bookStatusRepo)
        {
            _bookStatusRepo = bookStatusRepo;
        }
        public BookingStatus AddBookingStatus(BookingStatus B)
        {

            return _bookStatusRepo.AddBookingStatus(B);
        }

        public bool BookingStatusExists(int id)
        {
            bool res = _bookStatusRepo.BookingStatusExists(id);
            return res;
        }

        public void DeleteBookingStatus(int id)
        {
             _bookStatusRepo.DeleteBookingStatus(id);
        }

        public List<BookingStatus> GetBookingHistory(int id)
        {
            return _bookStatusRepo.GetBookingHistory(id);
        }

        public List<BookingStatus> GetBookingStatus()
        {
            return _bookStatusRepo.GetBookingStatus();
        }

        public BookingStatus GetBookingStatusById(int id)
        {
            return _bookStatusRepo.GetBookingStatusById(id);
        }

        public BookingStatus UpdateBookingStatus(int id, BookingStatus B)
        {
             //return _bookStatusRepo.UpdateBookingStatus(id, B);
            return _bookStatusRepo.AddBookingStatus(B);
        }
    }
}
