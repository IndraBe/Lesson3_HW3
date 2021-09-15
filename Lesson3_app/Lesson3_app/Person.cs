using System; //citas bibliotēkas, folderi, ko izmanto

namespace Lesson3_app
{
    public class Person
    {
        public Person(string name) //konstruktors. Lietotājam obligāti jāievada vārds un to pēc tam nedrīkst mainīt. Konstruktora nosaukuma jāsakrīt ar klases nosaukumu.
        {
            Name = name;
        }

        public string Name { get; } //noņem set, lai nebūtu iespējams mainīt vārdu. To uzstāda klases izveides brīdī un tāds arī paliek.

        //Property pilnais pieraksts. Katru reizi, kad personai tiek uzstādīts vecums, tas tiek uzstādits pozitīvs. Piem., uzstāda -30, patiesais vecums 30.
        private int _age; //pieejams tikai klases iekšienē, Nav pieejams uz ārpusi redzēšanai. Dati privāti, bet caur publiskām funkcijām to dabū uz āru (get & set).
        public int Age // publiski tiek izvadīts interface
        {
            get
            {
                return _age; //iegūst informāciju
            }
            set
            {
                _age = Math.Abs(value); //nosaka informāciju
            }
        }
        public double Money { get; set; }

        public bool IsMale { get; set; }

        public char Initial { get; set; }

        public string getGreeting()
        {
            string greeting = "Hello my name is " + Name + "and I am " + Age + " years old";

            return greeting;
        }
    }
}
