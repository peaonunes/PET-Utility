using PETUtility.Data.Context;
using PETUtility.Data.Providers;
using PETUtility.Data.Providers.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Business.Providers.Impl
{
    /// <summary>
    /// Classe responsável por ser a base do provider de business
    /// </summary>
    public abstract class BaseBusinessProvider : IDisposable
    {
        private IContext _Context;

        public IDataProvider CreateDataProvider()
        {
            this._Context = new PETUtilityContext();

            return new DataProvider(this._Context);
        }

        public PETUtilityContext GetContext()
        {
            return _Context as PETUtilityContext;
        }

        public void Dispose()
        {
            if (_Context != null)
                _Context.Dispose();

            _Context = null;
        }
    }
}
