using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Phone
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double LengthSize { get; set; }

        public double WidthSize { get; set; }

        public double HeightSize { get; set; }

        public string Call()
        {
            string getCall = "Contact us by calling";

            return getCall;
        }
        public string sendSMS()
        {
            string sms = "Contact us sending SMS";

            return sms;
        }
        
    }
}
