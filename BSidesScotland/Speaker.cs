using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSidesScotland
{
    public class Speaker : Person
    {
        private bool dinnerAttendee;
        private bool vegetarian;
        private string tshirtSize;
        private bool underEighteen;
        private string emergencyContactName;
        private string emergencyContactNumber;
        private string gender;
        private string talkTitle;
        private bool international;
        private DateTime dateSubmitted;
        private bool expReq;
        private string track;
        private bool talkAccepted;
        private bool confirmed;

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

        public string EmergencyContactName
        {
            get
            {
                return emergencyContactName;
            }

            set
            {
                emergencyContactName = value;
            }
        }

        public string EmergencyContactNumber
        {
            get
            {
                return emergencyContactNumber;
            }

            set
            {
                emergencyContactNumber = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string TalkTitle
        {
            get
            {
                return talkTitle;
            }

            set
            {
                talkTitle = value;
            }
        }

        public bool International
        {
            get
            {
                return international;
            }

            set
            {
                international = value;
            }
        }

        public DateTime DateSubmitted
        {
            get
            {
                return dateSubmitted;
            }

            set
            {
                dateSubmitted = value;
            }
        }

        public bool ExpReq
        {
            get
            {
                return expReq;
            }

            set
            {
                expReq = value;
            }
        }

        public string Track
        {
            get
            {
                return track;
            }

            set
            {
                track = value;
            }
        }

        public bool TalkAccepted
        {
            get
            {
                return talkAccepted;
            }

            set
            {
                talkAccepted = value;
            }
        }

        public bool Confirmed
        {
            get
            {
                return confirmed;
            }

            set
            {
                confirmed = value;
            }
        }

        public Speaker(string firstName, string surName) : base (firstName, surName)
        {

        }
    }
}
