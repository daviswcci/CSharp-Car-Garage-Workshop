using NUnit.Framework;
using Summer2022_Car_Garage_Program;

namespace Summer2022_Car_Garage_Tests
{
    // classes can have properties and methods.
    public class Tests
    {
        private Car _car;
        private Car _emptyCar;
        private Bicycle _bicycle;

        [SetUp]
        public void Setup()
        {
            // arrange
            _emptyCar = new Car(); // creating a car using the empty constructor
            _car = new Car("Chevrolet", "Camaro", 22, 100, 0, 184);
            _bicycle = new Bicycle("Ozone", false, BikeType.Mountain);
        }

        [Test]
        public void Car_Accelerate_Should_Increase_Speed_By_5()
        {
            // act
            _car.Accelerate();
            // assert
            Assert.AreEqual(5,_car.Speed);
        }
    }
}