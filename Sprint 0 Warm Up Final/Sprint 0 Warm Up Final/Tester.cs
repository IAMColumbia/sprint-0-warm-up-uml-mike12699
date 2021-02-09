using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_0_Warm_Up_Final
{
    class Tester
    {
        public void Test()
        {
            //AirportTester();
            AirplaneTest();
            ToyPlaneTest();
            HelicopterTest();
            DroneTester();
            Console.ReadKey();
        }

        /*public void AirportTester()
        {
            Airport ap = new Airport();
            Console.WriteLine("\nCall ap.AllTakeOff():");
            Console.WriteLine(ap.AllTakeOff());
        }*/

        public void HelicopterTest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Helicopter h = new Helicopter();
            Console.WriteLine("\n" + h.About());
            Console.WriteLine("\nCall h.TakeOff() shouldn't take off");
            Console.WriteLine(h.TakeOff());
            Console.WriteLine("\nCall h.StartEngine():");
            h.StartEngine();
            Console.WriteLine("Call h.TakeOff():");
            Console.WriteLine(h.TakeOff());
            Console.WriteLine("\nCall h.FlyUp():");
            h.FlyUp();
            Console.WriteLine("\nCall h.FlyUp(7000) Fly up to 8000ft:");
            h.FlyUp(7000);
            Console.WriteLine(h.About());
            Console.WriteLine("Call h.FlyDown(h.CurrentAltitude) this should land");
            h.FlyDown(h.currentAltitude);
            Console.WriteLine(h.About());
            Console.ResetColor();
        }

        public void DroneTester()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Drone d = new Drone();
            Console.WriteLine("\n" + d.About());
            Console.WriteLine("\nCall d.TakeOff() shouldn't take off");
            Console.WriteLine(d.TakeOff());
            Console.WriteLine("\nCall d.StartEngine():");
            d.StartEngine();
            Console.WriteLine("Call d.TakeOff():");
            Console.WriteLine(d.TakeOff());
            Console.WriteLine("\nCall d.FlyUp():");
            d.FlyUp();
            Console.WriteLine("\nCall d.FlyUp(500) Fly up to 500ft:");
            d.FlyUp(500);
            Console.WriteLine(d.About());
            Console.WriteLine("Call d.FlyDown(d.CurrentAltitude) this should land");
            d.FlyDown(d.currentAltitude);
            Console.WriteLine(d.About());
            Console.ResetColor();
        }

        public void ToyPlaneTest()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ToyPlane tp = new ToyPlane();
            Console.WriteLine("\n" + tp.About());
            Console.WriteLine("\nCall tp.TakeOff() shouldn't take off");
            Console.WriteLine(tp.TakeOff());
            Console.WriteLine("\nCall tp.StartEngine():");
            tp.StartEngine();
            Console.WriteLine("Call tp.TakeOff():");
            Console.WriteLine(tp.TakeOff());
            Console.WriteLine("\nCall tp.WindUp():");
            tp.WindUp();
            Console.WriteLine("Call tp.StartEngine():");
            tp.StartEngine();
            Console.WriteLine("Call tp.TakeOff():");
            Console.WriteLine(tp.TakeOff());
            Console.ResetColor();
        }

        public void AirplaneTest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Flying Vehicle Tester......................................................");
            Console.WriteLine("\nAirlplane.cs...............................................................");

            /*
             * Airplane class tests
             * many of the airplane class methods return a string we will write these to the console for testing
             */
            Airplane ap = new Airplane();
            //Air plane should inherit from AerialVehicle
            Console.WriteLine(ap.About());
            /* Output AirplaneAbout:
             * This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
             * It's current altitude is 0 ft.
             * OOPFlyingVehicleMidterm.Airplane engine is not started
             */

            Console.WriteLine("\nAireplaneTakeOffTests...............................................................");
            Console.WriteLine("\nCall ap.TakeOff():");
            //Test take off should fail engine isn't started
            Console.WriteLine(ap.TakeOff());  //Don't take off engine isn't started
            /* Output:
             * OOPFlyingVehicleMidterm.Airplane can't fly it's engine is not started.
             */
            Console.WriteLine("\nCall ap.StartEngine():");
            ap.StartEngine();
            Console.WriteLine(ap.TakeOff());  //take off engine is started
            /* Output:
             * OOPFlyingVehicleMidterm.Airplane is flying
             */

            //Fly up
            Console.WriteLine("\nFly up Tests...................................................................");
            Console.WriteLine("Call ap.FlyUp() fly to 1,000ft default");
            ap.FlyUp();    //Fly up tp 1,000 ft
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Fly up to 45,000ft:");
            ap.FlyUp(44000);    //Fly up tp 45,000 ft shouldn't work
            Console.WriteLine(ap.About());
            Console.WriteLine("\nCall ap.FlyUp(44000) Fly up another 40,000ft shouldn't work");
            ap.FlyUp(40000);    //Fly up tp 41,000 ft shouldn't work
            Console.WriteLine(ap.About());
            /*
             * Output:
             */

            //Land
            Console.WriteLine("\nFly Down.................................................................");
            Console.WriteLine("Call ap.FlyDown(50000) Fly Down 50,000 ft");
            ap.FlyDown(50000);   //Land by floying down 50,000 ft = Crash and shouldn't work
            Console.WriteLine(ap.About());
            Console.WriteLine("Call ap.FlyDown(ap.CurrentAltitude) this should land");
            ap.FlyDown(ap.currentAltitude); //Land by flying down current altitiute
            Console.WriteLine(ap.About());
            Console.ResetColor();
        }
    }
}
