using PETUtility.Business.Providers;
using PETUtility.Business.Providers.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Service.Services.Impl
{
    /// <summary>
    /// Classe responsável para ser a base dos serviços
    /// </summary>
    public abstract class BaseService
    {
        public IBusinessProvider CreateBusinessProvider()
        {
            return new BusinessProvider();
        }
    }
}
