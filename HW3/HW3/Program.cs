using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)         //call a method
        {
            Phone newObj1 = new Phone();          //creating object

            Console.WriteLine("Nosauciet telefona marku:");

            newObj1.Brand = Console.ReadLine();


            Console.WriteLine("Nosauciet telefona modeli:");

            newObj1.Model = Console.ReadLine();


            Console.WriteLine("Lūdzu, norādiet katrā rindā telefona garumu, platumu un augstumu:");

            newObj1.LengthSize = double.Parse(Console.ReadLine());
            newObj1.WidthSize = double.Parse(Console.ReadLine());
            newObj1.HeightSize = double.Parse(Console.ReadLine());

            Console.WriteLine("Jūs izvēlējāties: " + newObj1.Brand + " " + newObj1.Model + " / " + newObj1.LengthSize + " / " + newObj1.WidthSize + " / " + newObj1.HeightSize);
            
            string makeCall = newObj1.Call();
            Console.WriteLine(makeCall);

            string sendSMS = newObj1.SMS();
            Console.WriteLine(sendSMS);

        }
    }
}
