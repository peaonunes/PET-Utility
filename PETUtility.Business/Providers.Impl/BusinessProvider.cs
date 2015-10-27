using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Business.Providers.Impl
{
    /// <summary>
    /// Classe responsável pela comunicação com a camada de negócios
    /// </summary>
    public sealed class BusinessProvider : BaseBusinessProvider, IBusinessProvider
    {
        public IPETianoBusinessProvider CreatePETianoBusinessProvider()
        {
            return new PETianoBusinessProvider();
        }

        public IIdeaBusinessProvider CreateIdeaBusinessProvider()
        {
            return new IdeaBusinessProvider();
        }
    }
}
