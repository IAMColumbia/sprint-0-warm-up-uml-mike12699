using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sprint1;

namespace UnitTestSprint1
{
    [TestClass]
    public class AerialVehicleTests
    {
        Airplane airplane;
        ToyPlane toyplane;
        Engine engine;

        public AerialVehicleTests()
        {
            airplane = new Airplane();
            toyplane = new ToyPlane();
            engine = new Engine();
        }

        [TestMethod]
        public void ClassDefaultValues()
        {
            //Arrange
            Airplane a = airplane;
            ToyPlane tp = toyplane;
            Engine e = engine;

            //Act

            //Assert Airplane
            Assert.IsNotNull(a);
            Assert.AreEqual(a.maxAltitude, 41000);

            //Assert ToyPlane
            Assert.IsNotNull(tp);
            Assert.AreEqual(tp.maxAltitude, 50);
            Assert.AreEqual(tp.woundUp, false);

            //Assert Engine
            Assert.IsNotNull(e);
            Assert.AreEqual(e.isStarted, false);
        }

        [TestMethod]
        public void AirplaneTest()
        {
            //Arrange
            int afterMaxAltitude;

            //Act
            afterMaxAltitude = airplane.maxAltitude;

            //Assert
            Assert.AreEqual(afterMaxAltitude, airplane.maxAltitude);
            Assert.AreNotEqual(afterMaxAltitude, string.Empty);
        }

        /*[TestMethod]
        public void ToyPlaneEngine()
        {
            //Arrange
            bool WoundUp;
            string afterWoundUp;

            //Act
            WoundUp = toyplane.woundUp;
            afterWoundUp = toyplane.StartEngine();

            //Assert
            Assert.AreEqual(WoundUp, afterWoundUp);
            Assert.AreNotEqual(afterWoundUp, string.Empty);
        }*/

        [TestMethod]
        public void ToyPlaneTakeOff()
        {
            //Arrange
            bool WoundUp;
            string afterTakeOff;

            //Act
            WoundUp = toyplane.woundUp;
            afterTakeOff = toyplane.TakeOff();

            //Assert
            Assert.AreEqual(WoundUp, false);
            Assert.AreNotEqual(afterTakeOff, string.Empty);
        }

        [TestMethod]
        public void ToyPlaneWindUp()
        {
            //Arrange
            ToyPlane tp = toyplane;

            //Act

            //Assert
            Assert.AreEqual(tp.woundUp, false); 
        }

        [TestMethod]
        public void ToyPlaneWindDown()
        {
            //Arrange
            ToyPlane tp = toyplane;

            //Act

            //Assert
            Assert.AreEqual(tp.woundUp, false);
        }

        [TestMethod]
        public void ToyPlaneWindUpString()
        {
            //Arrange
            string afterWindUpString;

            //Act
            afterWindUpString = toyplane.WindUpString();

            //Assert
            Assert.AreEqual(afterWindUpString, "Not wound up");
            Assert.AreNotEqual(afterWindUpString, string.Empty);
        }

        [TestMethod]
        public void ToyPlaneAbout()
        {
            //Arrange
            string afterAbout;

            //Act
            afterAbout = toyplane.About();

            //Assert
            Assert.IsNotNull(toyplane);
            Assert.AreEqual(afterAbout, toyplane.About());
            Assert.AreNotEqual(afterAbout, string.Empty);
        }

        [TestMethod]
        public void EngineAbout()
        {
            //Arrange
            string afterAbout;

            //Act
            afterAbout = engine.About();

            //Assert
            Assert.IsNotNull(engine);
            Assert.AreEqual(afterAbout, engine.About());
            Assert.AreNotEqual(afterAbout, string.Empty);
        }
    }
}
