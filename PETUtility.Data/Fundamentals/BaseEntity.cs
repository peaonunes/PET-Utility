using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals
{
    /// <summary>
    /// Classe base da entidade
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        public virtual int Id { get; set; }
    }
}
