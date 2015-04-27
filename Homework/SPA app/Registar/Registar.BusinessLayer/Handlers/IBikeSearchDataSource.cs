using Registar.BusinessLayer.Contracts;
using System;

namespace Registar.BusinessLayer.Handlers
{
    interface IBikeSearchDataSource
    {
        BikeSearchResult ExecuteCommand(BikeSearchCommand command);
    }
}
