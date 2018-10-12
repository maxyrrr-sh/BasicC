using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentAddress
    {
        string country;
        string city;
        string address_;

        public StudentAddress(string country, string city, string address_)
        {
            this.country = country;
            this.city = city;
            this.address_ = address_;
        }

        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        public string City
        {
            set { city = value; }
            get { return city; }
        }

        public string Address
        {
            get { return address_; }
            set { address_ = value; }
        }

        public override string ToString()
        {
            return $"Country: {country}\nCity: {city}\nAddress{address_}";
        }
    }
}
