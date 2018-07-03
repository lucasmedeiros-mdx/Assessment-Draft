namespace Assessment
{
    public interface IVehicle
    {
        int NumberOfWheels { get; set; }
    }

    public class Car : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
    }

    public class MotorCycle : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool HasSideCar { get; set; }
    }

    public sealed class VehicleFactory
    {
        /*
         * Add the BuildFrame method to the VehicleFactoryClass. 
         * It should receive the NumberOfWheels as parameter and return a new vehicle.
         * 
         * Acceptance Criteria: Tests in VehicleFactoryTests should pass
         */
    }
}
