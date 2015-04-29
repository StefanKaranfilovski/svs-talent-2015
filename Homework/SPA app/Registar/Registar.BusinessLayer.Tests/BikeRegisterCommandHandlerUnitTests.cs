using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.BusinessLayer.Handlers;
using Registar.BL.Contracts.Contracts;

namespace Registar.BusinessLayer.Tests
{
    [TestClass]
    public class BikeRegisterCommandHandlerUnitTests
    {
        [TestMethod]
        public void ExecuteCommand_ValidBikeModel_NoExeption_Test()
        {
            //setup

            BikeRegisterCommandHandler handler = new BikeRegisterCommandHandler();
            BikeRegisterCommand command = new BikeRegisterCommand();

            //exercise

            BikeRegisterResult result = handler.Execute(command) as BikeRegisterResult;

            //verify

            Assert.IsNotNull(result, "For valid bike model result should not be null.");
            Assert.IsTrue(result.IsSuccess, "For valid bike model result should return success");

            //cleanup
        }

        //[TestMethod]
        //public void ExecuteCommand_InvalidBikeModel_ReturnsFalse_Test()
        //{

        //}
    }
}
