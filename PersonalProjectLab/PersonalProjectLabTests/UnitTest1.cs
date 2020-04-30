using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateFuelTest()
        {
            //Arrange
            Calcuations FuelClac = new Calcuations();

            //Act
            double Result;
            Result = FuelClac.CalculateFuel(16, 8);

            //Assert

            Assert.AreEqual(2.0, Result);
   
        }

        [TestMethod]
        public void CalculateItemTest()
        {
            //Arrange
            Calcuations FuelClac = new Calcuations();

            //Act
            double Result;
            Result = FuelClac.CalculateItems(16, 8);

            //Assert

            Assert.AreEqual(128, Result);
        }
    }
}
