using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals.Filters
{
    public class PETianoFilter
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public PETianoFilter(int id = 0, string login = null)
        {
            Id = id;
            Login = login;
        }
    }
}
