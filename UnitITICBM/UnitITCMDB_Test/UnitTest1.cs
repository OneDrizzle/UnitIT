using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitITICBM.Persistance;
using UnitITICBM.Models;

namespace UnitITCMDB_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomerExists()
        {
            //Arrange
            CIRepository cRepo = new CIRepository();

            CI testCI = cRepo.GetFromCI(1);

            //Act

            //Assert
            Assert.AreEqual(1, testCI.Customer.CustomerID);

        }
    }
}
