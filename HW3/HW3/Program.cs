using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            Console.WriteLine("Nosauciet telefona marku");

            string phoneBrand = Console.ReadLine();
            
            Console.WriteLine(phoneBrand);
            //phone.Brand = "IPhone";
            //phone.Model = "Pro";
            //phone.LengthSize = 15;
            //phone.WidthSize = 8;
            //phone.HeightSize = 2;

            //string getCall = phone.Call();
            //Console.WriteLine(getCall);

            //string sms = phone.sendSMS();
            //Console.WriteLine(sms);
        }
    }
}
