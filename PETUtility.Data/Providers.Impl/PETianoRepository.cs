using PETUtility.Data.Context;
using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers.Impl
{
    public class PETianoRepository : EntityRepository<PETiano>, IPETianoRepository
    {
        public PETianoRepository(IContext context)
            : base(context)
        {
        }

        public PETiano GetPETiano(PETianoFilter petianoFilter = null)
        {
            if (petianoFilter == null)
                petianoFilter = new PETianoFilter();

            return _Context.PETianos
                           .Where(y => petianoFilter.Login == null || y.Login.Equals(petianoFilter.Login))
                           .FirstOrDefault();
        }

        public List<PETiano> GetPETianos(PETianoFilter petianoFilter = null)
        {
            if (petianoFilter == null)
                petianoFilter = new PETianoFilter();

            return _Context.PETianos
                           .ToList();
        }
    }
}
