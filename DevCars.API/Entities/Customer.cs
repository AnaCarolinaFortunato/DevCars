using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Entities
{
    public class Customer
    {
        public Customer(int id, string fullName, string document, DateTime birthDate, List<Order> orders)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            BirthDate = birthDate;
            Orders = orders;

            Orders = new List<Order>();
        }

        public int  Id{ get; set; }
        public string FullName{ get; set; }
        public string Document { get; set; }
        public DateTime BirthDate{ get; set; }
        public List<Order> Orders{ get; set; }
    
    
    
    
    
    }
}
