using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSidesScotland
{
    public class Sponsor : Person
    {
        private string sponsorName;
        private string sponsorLevel;
        private string sponsorStatus;
        private bool contacted;
        private bool responded;
        private string result;
        private string contactedBy;
        private bool dinnerAttendee;
        private bool vegetarian;

        public string SponsorName
        {
            get
            {
                return sponsorName;
            }

            set
            {
                sponsorName = value;
            }
        }

        public string SponsorLevel
        {
            get
            {
                return sponsorLevel;
            }

            set
            {
                sponsorLevel = value;
            }
        }

        public string SponsorStatus
        {
            get
            {
                return sponsorStatus;
            }

            set
            {
                sponsorStatus = value;
            }
        }

        public bool Contacted
        {
            get
            {
                return contacted;
            }

            set
            {
                contacted = value;
            }
        }

        public bool Responded
        {
            get
            {
                return responded;
            }

            set
            {
                responded = value;
            }
        }

        public string Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public string ContactedBy
        {
            get
            {
                return contactedBy;
            }

            set
            {
                contactedBy = value;
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

        public Sponsor (string firstName, string surName) : base (firstName, surName)
        {

        }


    }
}
