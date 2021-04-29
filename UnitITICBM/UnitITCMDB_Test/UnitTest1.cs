using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitITICBM.Persistance;
using UnitITICBM.Models;
using System.Collections.Generic;

namespace UnitITCMDB_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomerExists()
        {
            //Arrange
            CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());

            //Act
            CI testCI = cRepo.GetFromCI(1);

            //Assert
            Assert.AreEqual(1, testCI.Customer.CustomerID);

        }

        [TestMethod]
        public void GetAll()
        {
            //Arrange
            CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());

            //Act
            List<CI> test = cRepo.GetAll();

            //Assert
            Assert.AreEqual(3, test.Count);
        }

        [TestMethod]
        public void GetCIType()
        {
            //Arrange
            CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());

            //Act
            Type testType = cRepo.types.Get(1);
            //Assert
            Assert.AreEqual("server", testType.TypeName);
        }

        [TestMethod]
        public void GetCustomer()
        {
            //Arrange
            CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());

            //Act
            Customer testCustomer = cRepo.customers.Get(1);
            //Assert
            Assert.AreEqual("UCL", testCustomer.CustomerName);
        }

        [TestMethod]
        public void GetAttributesFromSpecificCI()
        {
            //Arrange
            CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());

            //Act
            List<CIAttributes> testList = cRepo.attributes.GetAll(1);

            //Assert
            Assert.AreEqual(9, testList.Count);
        }

    }
}
