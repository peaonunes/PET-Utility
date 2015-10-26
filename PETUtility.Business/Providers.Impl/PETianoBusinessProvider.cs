using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using PETUtility.Data.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Business.Providers.Impl
{
    public class PETianoBusinessProvider : BaseBusinessProvider, IPETianoBusinessProvider
    {
        public PETiano GetPETiano(PETianoFilter petianoFilter = null)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IPETianoRepository repository = provider.CreatePETianoRepository())
                return repository.GetPETiano(petianoFilter);
        }

        public List<PETiano> GetPETianos(PETianoFilter petianoFilter = null)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IPETianoRepository repository = provider.CreatePETianoRepository())
                return repository.GetPETianos(petianoFilter);
        }


        public void CreatePETiano(PETiano petiano)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IPETianoRepository repository = provider.CreatePETianoRepository())
                repository.Create(petiano);
        }

        public void EditPETiano(PETiano petiano)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IPETianoRepository repository = provider.CreatePETianoRepository())
                repository.Update(petiano);
        }

        public void DeletePETiano(PETiano petiano)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IPETianoRepository repository = provider.CreatePETianoRepository())
                repository.Delete(petiano);
        }
    }
}
