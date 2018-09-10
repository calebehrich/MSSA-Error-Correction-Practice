using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NonMotorizedVehicles;
using Structures;

namespace TestMotorizedVehicle
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void TestIsDrivingClass()
        {
            Bicycle coupe = new Bicycle();
            bool isMoving = coupe.Moving;
            Assert.AreEqual(false, isMoving);

            bool hasStarted = coupe.Moving;
            Assert.IsTrue(hasStarted);

            bool hasStopped = coupe.Moving;
            Assert.IsFalse(hasStopped);        
        }

        //[TestMethod]
        public void TestIsDrivingStructure()
        {
            Tricycle trike = new Tricycle();
            bool isMoving = trike.Moving;
            Assert.AreEqual(false, isMoving);

            bool hasStarted = trike.Moving;
            Assert.IsTrue(hasStarted);

            bool hasStopped = trike.Moving;
            Assert.IsFalse(hasStopped);
        }
    }
}
