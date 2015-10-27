using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals.Models
{
    /// <summary>
    /// Classe responsável por representar ideias
    /// </summary>
    public class Idea : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PETianoId { get; set; }
    }
}
