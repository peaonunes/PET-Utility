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
    public class IdeaBusinessProvider : BaseBusinessProvider, IIdeaBusinessProvider
    {
        public List<Idea> GetIdeas(IdeaFilter ideaFilter = null)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IIdeaRepository repository = provider.CreateIdeaRepository())
                return repository.GetIdeas(ideaFilter);
        }

        public void CreateIdea(Idea idea)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IIdeaRepository repository = provider.CreateIdeaRepository())
                repository.Create(idea);
        }

        public void EditIdea(Idea idea)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IIdeaRepository repository = provider.CreateIdeaRepository())
                repository.Update(idea);
        }

        public void DeleteIdea(Idea idea)
        {
            using (IDataProvider provider = base.CreateDataProvider())
            using (IIdeaRepository repository = provider.CreateIdeaRepository())
                repository.Delete(idea);
        }
    }
}
