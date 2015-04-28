using Registar.Common.Interfaces;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository.Interfaces
{
    public interface IBikeRepository : IRepository
    {
        IList<Bike> SearchBikes(SearchFilter filter);
    }
}
