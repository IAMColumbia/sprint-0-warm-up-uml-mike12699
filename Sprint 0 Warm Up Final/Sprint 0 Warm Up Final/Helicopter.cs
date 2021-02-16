using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    public class Helicopter : AerialVehicle
    {
        public int NumRotors;
        public bool HasTailRotor;

        public Helicopter() : this(2, true)
        {

        }

        public Helicopter(int NumberofRotors, bool HasTailRotor)
        {
            this.maxAltitude = 8000;
            this.NumRotors = NumberofRotors;
            this.HasTailRotor = HasTailRotor;
            this.engine = new Engine();
        }

        public override string About()
        {
            return base.About() + $" {this.NumRotors} : rotors and {this.HasTailRotorString()}.";
        }

        private string HasTailRotorString()
        {
            if (this.HasTailRotor)
                return "has tail rotor";
            return "has no tail rotor";
        }
    }
}
