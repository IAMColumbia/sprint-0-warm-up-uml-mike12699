using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    public class Engine
    {
        public bool isStarted;

        public Engine()
        {
            this.isStarted = false;
        }

        public void Start()
        {
            this.isStarted = true;
        }

        public void Stop()
        {
            this.isStarted = false;
        }

        public string About()
        {
            string stringEngine = this.ToString() + " is not started.";
            if (this.isStarted)
            {
                stringEngine = stringEngine.Replace("not ", "");
            }
            return stringEngine;
        }
    }
}
