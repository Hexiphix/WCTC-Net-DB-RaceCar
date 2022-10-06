using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class CheapOldCar : RaceCar
    {
        public CheapOldCar()
        {
            Name = "Cheap Old Car";
            TopSpeed = 70;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name}, to everyone's suprise, actually manages to start");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} trys to stop, and the brakes don't give out!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine stops as if relieved to be done");
        }
    }
}
