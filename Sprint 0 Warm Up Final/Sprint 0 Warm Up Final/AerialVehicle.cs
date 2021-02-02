using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_0_Warm_Up_Final
{
    public abstract class AerialVehicle
    {
        public Engine engine;
        public int currentAltitude;
        public bool isFlying;
        public int maxAltitude;

        public AerialVehicle()
        {
            this.isFlying = false;
            this.currentAltitude = 0;
            this.engine = new Engine();
        }

        protected string GetEngineString()
        {
            return this.engine.About();
        }

        public virtual string About()
        {
            string about = string.Format("This {0} has a max altitude of {1} ft. \nIt's current altitude is {2} ft. \n{3}", this.ToString(), this.maxAltitude.ToString(), this.currentAltitude, this.GetEngineString());
            return about;
        }

        public virtual string TakeOff()
        {
            if (engine.isStarted)
            {
                this.isFlying = true;
                return string.Format("{0} is flying", this);
            }
            return string.Format("{0} cannot fly. The engine has not started yet", this);
        }

        public virtual void StartEngine()
        {
            this.engine.Start();
        }

        public virtual void StopEngine()
        {
            this.engine.Stop();
        }

        public void FlyDown()
        {
            this.FlyDown(1000);
        }

        public void FlyDown(int howMuch)
        {
            if (this.isFlying)
            {
                if (this.isFlying)
                {
                    if (this.currentAltitude - howMuch >= 0)
                        this.currentAltitude -= howMuch;
                    if (this.currentAltitude <= 0)
                    {
                        this.currentAltitude = 0;
                        this.isFlying = false;
                    }
                }
            }
        }

        public void FlyUp()
        {
            this.FlyUp(1000);
        }

        public void FlyUp(int HowMuch)
        {
            if (this.isFlying)
            {
                if (this.currentAltitude + HowMuch <= this.maxAltitude)
                    this.currentAltitude += HowMuch;
            }
        }
    }
}
