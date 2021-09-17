using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Phone
    {
        public string Brand { get; set; }   //field
        
        public string Model { get; set; }   //field

        public double LengthSize { get; set; }  //field

        public double WidthSize { get; set; }   //field

        public double HeightSize { get; set; }  //field

        public string Call()                  //method
        {
            string makeCall = "Piezvaniet, ja rodas kāds jautājums.";
            //string getCall = "Contact us by calling";
            return makeCall;
        }
        public string SMS()               //method
        {
            string sendSMS = "Vai arī atsūtiet SMS.";
            //string sms = "Contact us sending SMS";
            return sendSMS;
        }
        
    }
}
