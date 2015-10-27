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
    public class IdeaRepository : EntityRepository<Idea>, IIdeaRepository
    {
        public IdeaRepository(IContext context)
            : base(context)
        {
        }

        public List<Idea> GetIdeas(IdeaFilter ideaFilter = null)
        {
            if (ideaFilter == null)
                ideaFilter = new IdeaFilter();

            return _Context.Ideas
                          .Where(y => ideaFilter.PETianoId == 0 || y.PETianoId == ideaFilter.PETianoId)
                          .ToList();
        }
    }
}
