using System;

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
            return makeCall;
        }
        public string SMS()               //method
        {
            string sendSMS = "Vai arī atsūtiet SMS.";
            return sendSMS;
        }
        
    }
}
