using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Address
    {
        private string _city;
        private string _street;
        private int _home;

        public Address()
        {
            this._city = "Alicante";
            this._street = "Castanos";
            this._home = 43;
        }
        public Address(string city, string street, int home)
        {
            this._city = city;
            this._street = street;
            this._home = home;
        }
        public string City_
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street_
        {
            get { return _street; }
            set { _street = value; }
        }
        public int Home_
        {
            get { return _home; }
            set { _home = value; }
        }
    }
}