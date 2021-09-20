using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)         //call a method
        {
            //Phone newObj1 = new Phone();          //creating object

            //Console.WriteLine("Nosauciet telefona zīmolu:");

            //newObj1.Brand = Console.ReadLine();


            //Console.WriteLine("Nosauciet telefona modeli:");

            //newObj1.Model = Console.ReadLine();


            //Console.WriteLine("Lūdzu, norādiet katrā rindā telefona garumu(cm), platumu(cm) un augstumu(cm):");

            //newObj1.LengthSize = double.Parse(Console.ReadLine());
            //newObj1.WidthSize = double.Parse(Console.ReadLine());
            //newObj1.HeightSize = double.Parse(Console.ReadLine());

            //Console.WriteLine("Jūs izvēlējāties šādu telefonu: " +
            //                    newObj1.Brand + " " +
            //                    newObj1.Model + " / " +
            //                    newObj1.LengthSize + "cm / " +
            //                    newObj1.WidthSize + "cm / " +
            //                    newObj1.HeightSize + "cm.");

            //string makeCall = newObj1.Call();
            //Console.WriteLine(makeCall);

            //string sendSMS = newObj1.SMS();
            //Console.WriteLine(sendSMS);


            //Console.WriteLine("================================================================================");

            //Car newCar1 = new Car();          //creating object

            //Console.WriteLine("Nosauciet mašīnas marku, nummurzīmi un pašreizējo ātrumu:");

            //newCar1.carBrand = Console.ReadLine();
            //newCar1.carPlate = Console.ReadLine();
            //newCar1.carSpeed = int.Parse(Console.ReadLine());

            //Console.WriteLine("Jūsu izvēlējātā mašīna ir ar šādiem parametriem: " +
            //                        newCar1.carBrand + " / " +
            //                        newCar1.carPlate + " / " +
            //                        newCar1.carSpeed + " km/h");

            //Console.WriteLine("-------------------------");

            //int speed = newCar1.carSpeed;
            //bool fromStart = speed == 0;

            //string startDriving = newCar1.Start();
            //string continueDriving = newCar1.contSpeed();
            //Console.WriteLine(fromStart ? startDriving : continueDriving);

            //Console.ReadLine();

            //string upSpeed = newCar1.IncreaseSpeed();
            //Console.WriteLine(upSpeed);

            //Console.ReadLine();

            //string speedDown = newCar1.DecreaseSpeed();
            //Console.WriteLine(speedDown);

            //Console.ReadLine();

            //string beep = newCar1.Signal();
            //Console.WriteLine(beep);

            //Console.ReadLine();

            //string stopDriving = newCar1.Stop();
            //Console.WriteLine(stopDriving);

            ////string startDriving = newCar1.Start();        //Vai viena un tā pati metode var tikt izsaukta vairākas reizes? Piemēram, atkal uzsākt braukt.
            ////Console.WriteLine(startDriving);


            //Console.WriteLine("================================================================================");

            //Console.WriteLine("Lūdzu ievadiet preces garumu (cm), platumu (cm) un svaru (kg):");

            //double lengthsize = double.Parse(Console.ReadLine());

            //double widthhsize = double.Parse(Console.ReadLine());

            //double weight = double.Parse(Console.ReadLine());

            //Product newProduct1 = new Product(lengthsize, widthhsize, weight);          //creating object

            //Console.WriteLine("Press Enter"); 
            //Console.ReadLine();

            //string createProduct = newProduct1.Create();
            //Console.WriteLine(createProduct);

            //string showProduct = newProduct1.Show(lengthsize, widthhsize, weight);      //method + parameters
            //Console.WriteLine(showProduct);

            //newProduct1.Length = 34.6;                //to test if not possible to change
            //newProduct1.Width = 34.6;

            Console.WriteLine("================================================================================");

            Console.WriteLine("Lūdzu, ievadiet savu ");
            Console.WriteLine("vārdu:");
            //newPerson1.Name = Console.ReadLine();
            string personname = Console.ReadLine();

            Console.WriteLine("uzvārdu:");
            string personsurname = Console.ReadLine();

            Person newPerson1 = new Person(personname, personsurname);

            
            //newPerson1.Surname = Console.ReadLine();

            Console.WriteLine("dzimšanas datumu:");
            newPerson1.BirthDate = Console.ReadLine();

            Console.WriteLine("hobiju:");
            newPerson1.Hobby = Console.ReadLine();

            Console.WriteLine("dzimumu:");
            newPerson1.Gender = Console.ReadLine();

            string greet = newPerson1.SayHi();
            Console.WriteLine(greet);
        }
    }         
}
