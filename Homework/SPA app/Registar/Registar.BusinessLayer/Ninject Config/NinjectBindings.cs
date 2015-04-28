using Ninject.Modules;
using Registar.BusinessLayer.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Ninject_Config
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IBikeSearchDataSource>().To<BikeSearchRegistarDb>();
        }
    }
}
