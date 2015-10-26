using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers
{
    public interface IPETianoRepository : IEntityRepository<PETiano>
    {
        PETiano GetPETiano(PETianoFilter petianoFilter = null);
        List<PETiano> GetPETianos(PETianoFilter petianoFilter = null);
    }
}
