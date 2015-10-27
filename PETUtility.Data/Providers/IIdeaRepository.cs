using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers
{
    public interface IIdeaRepository : IEntityRepository<Idea>
    {
        List<Idea> GetIdeas(IdeaFilter ideaFilter = null);
    }
}
