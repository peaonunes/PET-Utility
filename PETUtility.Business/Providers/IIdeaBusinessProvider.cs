using PETUtility.Data.Fundamentals.Filters;
using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Business.Providers
{
    public interface IIdeaBusinessProvider : IDisposable
    {
        List<Idea> GetIdeas(IdeaFilter ideaFilter = null);
        void CreateIdea(Idea idea);
        void EditIdea(Idea idea);
        void DeleteIdea(Idea idea);
    }
}
