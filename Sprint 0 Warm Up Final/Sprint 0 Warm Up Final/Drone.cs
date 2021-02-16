using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    public class Drone : AerialVehicle
    {
        public int DroneRotors;

        public Drone() : this(4)
        {

        }

        public Drone(int droneRotors)
        {
            this.maxAltitude = 500;
            this.DroneRotors = droneRotors;
            this.engine = new Engine();
        }

        public override string About()
        {
            return base.About() + $" {this.DroneRotors} rotors.";
        }
    }
}
