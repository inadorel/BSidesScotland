using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSidesScotland
{
    public class Address
    {
        private string address1;
        private string address2;
        private string town;
        private string postcode;
        private string country;

        public Address()
        {
        
        }

        public Address(string address1, string town)
        {
            this.address1 = address1;
            this.town = town;
        }

        public string Address1
        {
            get
            {
                return address1;
            }

            set
            {
                address1 = value;
            }
        }

        public string Address2
        {
            get
            {
                return address2;
            }

            set
            {
                address2 = value;
            }
        }

        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                town = value;
            }
        }

        public string Postcode
        {
            get
            {
                return postcode;
            }

            set
            {
                postcode = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
    }
}
