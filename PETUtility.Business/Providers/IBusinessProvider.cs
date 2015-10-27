using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Business.Providers
{
    public interface IBusinessProvider : IDisposable
    {
        IPETianoBusinessProvider CreatePETianoBusinessProvider();
        IIdeaBusinessProvider CreateIdeaBusinessProvider();
    }
}
