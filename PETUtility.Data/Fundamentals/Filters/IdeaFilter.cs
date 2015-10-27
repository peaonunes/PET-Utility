using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals.Filters
{
    public class IdeaFilter
    {
        public int PETianoId { get; set; }

        public IdeaFilter(int petianoId = 0)
        {
            this.PETianoId = petianoId;
        }
    }
}
