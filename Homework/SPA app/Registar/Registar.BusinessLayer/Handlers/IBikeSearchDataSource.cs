using Registar.BusinessLayer.Contracts;
using System;

namespace Registar.BusinessLayer.Handlers
{
    public interface IBikeSearchDataSource
    {
        BikeSearchResult ExecuteCommand(BikeSearchCommand command);
    }
}
