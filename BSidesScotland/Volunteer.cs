using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSidesScotland
{
    class Volunteer : Person
    {
        private string tshirtSize;
        private bool dinnerAttendee;
        private bool vegetarian;
        private bool underEighteen;

        public Volunteer()
        {

        }

        public Volunteer(string firstName, string surName) : base (firstName, surName)
        {

        }


        public string TshirtSize
        {
            get
            {
                return tshirtSize;
            }

            set
            {
                tshirtSize = value;
            }
        }

        public bool DinnerAttendee
        {
            get
            {
                return dinnerAttendee;
            }

            set
            {
                dinnerAttendee = value;
            }
        }

        public bool Vegetarian
        {
            get
            {
                return vegetarian;
            }

            set
            {
                vegetarian = value;
            }
        }

        public bool UnderEighteen
        {
            get
            {
                return underEighteen;
            }

            set
            {
                underEighteen = value;
            }
        }
    }

}
