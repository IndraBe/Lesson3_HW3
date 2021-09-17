using System;

namespace HW3
{
    class Car
    {

        public string carBrand { get; set; }

        public string carPlate { get; set; }

        public int carSpeed { get; set; }

        public string Start()                  //method
        {
            string startDriving = "Tiek uzsākta braukšana";
            return startDriving;
        }

        public string IncreaseSpeed()                  //method
        {
            string upSpeed = "Palielinam ātrumu līdz maksimāli atļautajam";
            return upSpeed;
        }

        public string DecreaseSpeed()                  //method
        {
            string speedDown = "Ātrums tiek samazināts, jo priekšā šķērslis";
            return speedDown;
        }

        public string contSpeed()                  //method
        {
            string continueDriving = "Turpinām braukt";
            return continueDriving;
        }

        public string Signal()                  //method
        {
            string beep = "Beep Beep";
            return beep;
        }

        public string Stop()                  //method
        {
            string stopDriving = "Mašīna apturēta";
            return stopDriving;
        }
    }
}
