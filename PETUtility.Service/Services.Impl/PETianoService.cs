using PETUtility.Business.Providers;
using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Service.Services.Impl
{
    public class PETianoService : BaseService, IPETianoService
    {
        public PETiano GetPETiano(PETianoFilter petianoFilter = null)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IPETianoBusinessProvider prov = provider.CreatePETianoBusinessProvider())
                return prov.GetPETiano(petianoFilter);
        }


        public List<PETiano> GetPETianos(PETianoFilter petianoFilter = null)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IPETianoBusinessProvider prov = provider.CreatePETianoBusinessProvider())
                return prov.GetPETianos(petianoFilter);
        }


        public void CreatePETiano(PETiano petiano)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IPETianoBusinessProvider prov = provider.CreatePETianoBusinessProvider())
                prov.CreatePETiano(petiano);
        }

        public void EditPETiano(PETiano petiano)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IPETianoBusinessProvider prov = provider.CreatePETianoBusinessProvider())
                prov.EditPETiano(petiano);
        }

        public void DeletePETiano(PETiano petiano)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IPETianoBusinessProvider prov = provider.CreatePETianoBusinessProvider())
                prov.DeletePETiano(petiano);
        }
    }
}
