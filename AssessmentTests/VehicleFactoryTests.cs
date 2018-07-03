using Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTests
{
    [TestClass]
    public class VehicleFactoryTests
    {
        [TestMethod]
        public void BuildingFrameShouldReturnNewCar()
        {
            var factory = new VehicleFactory();

            // var car = factory.BuildFrame<Car>(numberOfWheels: 4);

            // Assert.IsInstanceOfType(car, typeof(Car));
        }

        [TestMethod]
        public void BuildingFrameShouldReturnNewMotorCycle()
        {
            var factory = new VehicleFactory();

            // MotorCycle motorCycle = factory.BuildFrame<MotorCycle>(numberOfWheels: 2);

            // Assert.IsInstanceOfType(motorCycle, typeof(MotorCycle));
        }
    }
}
