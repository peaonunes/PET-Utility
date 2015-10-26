using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers
{
    public interface IDataProvider : IDisposable
    {
        IPETianoRepository CreatePETianoRepository();
    }
}
