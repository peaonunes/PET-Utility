using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Service.Services
{
    public interface IService
    {
        IPETianoService CreatePETianoService();
        IIdeaService CreateIdeaService();
    }
}
