using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    public class Airport
    {
        List<AerialVehicle> Vehicles;
        protected int MaxVehicles;
        public string AirportCode { get; protected set; }

        public Airport()
        {

        }

        public Airport(string Code) : this(Code, 5)
        {

        }

        public Airport(string Code, int MaxVehicles)
        {
            this.AirportCode = Code;
            this.Vehicles = new List<AerialVehicle>();
            this.MaxVehicles = MaxVehicles;
        }

        public string Land (AerialVehicle a)
        {
            if (this.Vehicles.Count < this.MaxVehicles)
            {
                this.Vehicles.Add(a);
                if (a.currentAltitude > 0)
                {
                    a.FlyDown(a.currentAltitude);
                }
                return string.Format("{0} lands at {1}", a, this.AirportCode);
            }
            return string.Format($"{this} is full. Can't land here");
        }

        public string TakeOff(AerialVehicle a)
        {
            this.Vehicles.Remove(a);
            return a.TakeOff() + " from " + this.AirportCode;
        }

        public string AllTakeOff()
        {
            string allTakeOff = string.Empty;
            foreach (AerialVehicle av in this.Vehicles)
            {
                allTakeOff += this.TakeOff(av);
            }
            return allTakeOff;
        }

        public string Land (List<AerialVehicle> landing)
        {
            string stringLand = string.Empty;
            foreach (AerialVehicle av in landing)
            {
                stringLand += this.Land(av);
            }
            return stringLand;
        }
    }
}
