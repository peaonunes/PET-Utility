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
    public class IdeaService : BaseService, IIdeaService
    {
        public List<Idea> GetIdeas(IdeaFilter ideaFilter = null)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IIdeaBusinessProvider prov = provider.CreateIdeaBusinessProvider())
                return prov.GetIdeas(ideaFilter);
        }

        public void CreateIdea(Idea idea)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IIdeaBusinessProvider prov = provider.CreateIdeaBusinessProvider())
                prov.CreateIdea(idea);
        }

        public void EditIdea(Idea idea)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IIdeaBusinessProvider prov = provider.CreateIdeaBusinessProvider())
                prov.EditIdea(idea);
        }

        public void DeleteIdea(Idea idea)
        {
            using (IBusinessProvider provider = base.CreateBusinessProvider())
            using (IIdeaBusinessProvider prov = provider.CreateIdeaBusinessProvider())
                prov.DeleteIdea(idea);
        }
    }
}
