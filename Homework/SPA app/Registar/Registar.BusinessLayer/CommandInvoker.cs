using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.BusinessLayer.Handlers;
using Ninject;
using System.Reflection;

namespace Registar.BusinessLayer
{
    /// <summary>
    /// Provides method for invoking commands from other layers
    /// </summary>
    public class CommandInvoker
    {
        /// <summary>
        /// Entry point for execution of different commands
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static TResult InvokeCommand<TRequest, TResult>(TRequest command) where TRequest : Command
                                                                                 where TResult : CommandResult
        {
            //
            IHandler _handler = GetHandler<TRequest>();
            TResult _result = default(TResult);
            //
            if (_handler != null)
            {
                _result = (TResult)_handler.Execute(command);
            }
            //
            return _result;
        }

        /// <summary>
        /// Factory method for creating handlers
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <returns></returns>
        private static IHandler GetHandler<TRequest>()
        {
            IKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());

            if (typeof (TRequest) == typeof (BikeSearchCommand))
            {
                IBikeSearchDataSource _dataSource = _kernel.Get<IBikeSearchDataSource>();

                return new BikeSearchCommandHandler(_dataSource);
            }
            //
            return null;
        }
    }
}
