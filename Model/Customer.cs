using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSAPI.Model
{
    public class Customer
    {
        [Key]

        public int UserId { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }


        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }


        public string UserType { get; set; }

        public bool IsVerified { get; set; }
        public Customer()
        {
        }

        //public Product(string PrdName, int Qty, float prc)
        //{
        //    ProcuctName = PrdName;
        //    QtyOnHand = Qty;
        //    price = prc;

        //}
        public Customer(int id, string CName, string UName,string pwd,int cage,string Mobile,string Addres,string UserTyp ,bool verify)
        {
           UserId = id;
            Name = CName;
           UserName = UName;
            Password = pwd;
            Age = cage;
            Phone = Mobile;
            Address = Addres;
            UserType = UserTyp;
            IsVerified = verify;
        }
    }
}
