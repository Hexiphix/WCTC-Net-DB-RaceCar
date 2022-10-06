using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class YoungsterJoey : Driver
    {
        public YoungsterJoey(RaceCar car) : base(car)
        {
            Name = "Youngster Joey";
            SkillLevel = 2;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
