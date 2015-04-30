using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registar.BusinessLayer.Handlers;
using Registar.BL.Contracts.Contracts;
using Registar.Common;
using Registar.Common.Interfaces;
using Registar.Repository.Interfaces;
using Registar.DomainModel;

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

        [TestMethod]
        public void ExecuteCommand_NotExistingOwnerId_ValidationError_Test()
        {
            //setup
            RepositoryManager.RegisterFactory(new BikeRegisterFactoryStub());
            BikeRegisterCommandHandler handler = new BikeRegisterCommandHandler();
            BikeRegisterCommand command = new BikeRegisterCommand();
            command.BikeToRegister = new Bike();
            //not valid onwer ids are negative numbers
            command.BikeToRegister.BikeOwnerId = int.MinValue;
            //exercise
            BikeRegisterResult result = handler.Execute(command) as BikeRegisterResult;
            //verify
            Assert.IsFalse(result.IsSuccess,"For not valid owner id operation should be unsuccesfull!");
            StringAssert.Contains(result.ValidationErrors[0],"not valid ownerid","For not valid owner id validation error is expected!");
            //cleanup
        }

        [TestMethod]
        public void ExecuteCommand_ValidBikeData_RepoSaveMethodCalled_Test()
        {
            //setup
            RepositoryManager.RegisterFactory(new BikeRegisterFactoryStub());
            BikeRegisterCommandHandler handler = new BikeRegisterCommandHandler();
            BikeRegisterCommand command = new BikeRegisterCommand();
            command.BikeToRegister = new Bike();
            command.BikeToRegister.BikeOwnerId = 1;
            //exercise
            BikeRegisterResult result = handler.Execute(command) as BikeRegisterResult;
            //verify
            Assert.IsTrue(BikeRegisterFactoryStub.Spy.SpyVarSaveCalled, "The SaveBike method should be called with valid data!");
            //cleanup
        }
    }

    public class BikeRegisterFactoryStub:IRepositoryFactory
    {
        public static BikeRegisterRepoSpy Spy { get; set; }

        static BikeRegisterFactoryStub()
        {
            Spy = new BikeRegisterRepoSpy();
        }

        public TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            return (TRepository) (object) Spy;
        }
    }

    public class BikeRegisterRepoSpy : IBikeRepository
    {
        public bool SpyVarSaveCalled { get; set; }

        public System.Collections.Generic.IList<Bike> SearchBikes(Contracts.BikeSearchCommand command)
        {
            throw new NotImplementedException();
        }

        public bool SaveBike(Bike bikeToSave)
        {
            this.SpyVarSaveCalled = true;
            return true;
        }
    }
}
