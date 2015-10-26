using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Service.Services
{
    public interface IPETianoService
    {
        PETiano GetPETiano(PETianoFilter petianoFilter = null);
        List<PETiano> GetPETianos(PETianoFilter petianoFilter = null);
        void CreatePETiano(PETiano petiano);
        void EditPETiano(PETiano petiano);
        void DeletePETiano(PETiano petiano);
    }
}
