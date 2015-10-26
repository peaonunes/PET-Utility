using PETUtility.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers.Impl
{
    /// <summary>
    /// Classe responsável por criar os repositórios
    /// </summary>
    public sealed class DataProvider : IDataProvider
    {
        private IContext _Context;

        public DataProvider(IContext context)
        {
            _Context = context;
        }

        public IPETianoRepository CreatePETianoRepository()
        {
            return new PETianoRepository(this._Context);
        }

        public void Dispose()
        {
            if (_Context != null)
            {
                _Context.Dispose();
                _Context = null;
            }
        }
    }
}
