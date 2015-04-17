using System;

using NUnit.Framework;

namespace tdd_demo
{
    [TestFixture]
    public class EnterpriceArchitectureTests
    {
        [Test]
        public void DataService_AddData_Returns_True()
        {
            //arrange
            var service = new DataService();
            var request = new DataRequest { Value = "test data" };

            //act
            var response = service.AddData(request);

            //asset
            Assert.IsTrue(response);
        }

        [Test,
         ExpectedException(typeof(Exception))]
        public void DataService_AddData_ThrowsException_When_Request_Invalid()
        {
            //arrange
            var service = new DataService();
            var request = new DataRequest();

            //act
            var response = service.AddData(request);

            //asset
            Assert.IsTrue(response);
        }
    }

    public class DataRequest
    {
        public string Value { get; set; }

        public bool IsNotValid()
        {
            return string.IsNullOrWhiteSpace(Value);
        }
    }

    public class DataService
    {
        public bool AddData(DataRequest request)
        {
            if (request.IsNotValid())
            {
                throw new Exception("request not valid");
            }

            //todo:save to db

            return true;
        }
    }
}