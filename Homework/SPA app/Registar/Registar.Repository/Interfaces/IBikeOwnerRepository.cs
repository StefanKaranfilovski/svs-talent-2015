using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository.Interfaces
{
    public interface IBikeOwnerRepository : IRepository
    {
        bool UpdateProfileData();
    }
}
