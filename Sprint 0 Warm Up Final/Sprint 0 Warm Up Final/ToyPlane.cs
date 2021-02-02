using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_0_Warm_Up_Final
{
    class ToyPlane : Airplane
    {
        protected bool woundUp;

        public ToyPlane()
        {
            this.maxAltitude = 50;
            this.woundUp = false;
        }

        public override void StartEngine()
        {
            if (this.woundUp)
            {
                base.StartEngine();
            }
        }

        public override string TakeOff()
        {
            if (this.woundUp)
            {
                return base.TakeOff();
            }
            return string.Format("{0} cannot take off when it's not wound up ", this) + base.TakeOff();
        }

        public void WindUp()
        {
            this.woundUp = true;
        }

        public void WindDown()
        {
            this.woundUp = false;
        }

        protected string WindUpString()
        {
            string isWoundUp = "Not wound up";
            if (woundUp) isWoundUp = isWoundUp.Replace("not ", "");
            return isWoundUp;
        }

        public override string About()
        {
            return base.About() + "\n" + this.WindUpString();
        }
    }
}
