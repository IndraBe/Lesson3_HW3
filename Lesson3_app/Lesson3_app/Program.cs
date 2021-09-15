using System;

namespace Lesson3_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Indra"); //Person - Klase. person ir Objekts. svarīgākais - NEW. Vārds pēdiņās konstruktors no klases.

            Person person2 = person; //piekļūst vienam un tam pašam objektam. Jauna persona izveidojas tikai ar NEW. Referencējas tieši uz to pašu objektu.

            //person.Name = "Indra"; //uzstāda datus / uz vērtību nokļūst caur .
            person.Age = 15;
            person.IsMale = true;
            person.Money = 160.60;
            person.Intial = 'I';

            person2.Age = 26;  //2 mainīgie, viena vieta atmiņā, tāpēc pirmo nozīmēto vērtību aizstāj otra nozīmētā vērtība

            string greeting = person.getGreeting();

            Console.WriteLine(greeting);
        }
    }
}
