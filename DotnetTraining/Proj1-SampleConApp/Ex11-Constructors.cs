using System;

namespace Proj1_SampleConApp
{
    class Infotainment
    {
        public int InfoId { get; set; }
        public string Name { get; set; }
        public string Speakers { get; set; }
        public void Play() => Console.WriteLine($"The Music is playing on {Name} with {Speakers}!!!!");
    }

    class Car
    {
        public Infotainment MusicSystem { get; private set; }

        public Car(Infotainment mySystem)
        {
            MusicSystem = mySystem;
        }
        public void RunCar()
        {
            Console.WriteLine("The Car is running");
            MusicSystem.Play();
        }
    }
    class Ex11_Constructors
    {
        static void Main(string[] args)
        {
            Infotainment mySystem = new Infotainment { InfoId = 1, Name = "SONY", Speakers="JBL Speakers" };
            Car hondaCar = new Car(mySystem);
          
            hondaCar.RunCar();
        }
    }
}
