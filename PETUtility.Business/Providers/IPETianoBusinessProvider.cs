using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Business.Providers
{
    public interface IPETianoBusinessProvider : IDisposable
    {
        PETiano GetPETiano(PETianoFilter petianoFilter = null);
        List<PETiano> GetPETianos(PETianoFilter petianoFilter = null);
        void CreatePETiano(PETiano petiano);
        void EditPETiano(PETiano petiano);
        void DeletePETiano(PETiano petiano);
    }
}
