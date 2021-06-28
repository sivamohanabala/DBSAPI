using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSAPI.Model
{
    public class BookingDetail
    {
        [Key]

        public int BookingId { get; set; }

        public int UserId { get; set; }

        public DateTime PickUp { get; set; }

        public float Package { get; set; }

        public DateTime BTime { get; set; }

        public string Status { get; set; }

        public int Price { get; set; }

        public string DExecutive { get; set; }
    }
}
