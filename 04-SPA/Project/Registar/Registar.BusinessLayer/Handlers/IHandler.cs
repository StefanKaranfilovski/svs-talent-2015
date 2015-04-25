using Registar.BusinessLayer.Contracts;
using System;

namespace Registar.BusinessLayer.Handlers
{
    internal interface IHandler
    {
        CommandResult Execute(Command command);
    }
}
