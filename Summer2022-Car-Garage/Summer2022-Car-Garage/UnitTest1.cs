using NUnit.Framework;
using Summer2022_Car_Garage_Program;

namespace Summer2022_Car_Garage
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Car car = new Car();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}