using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals
{
    public interface IEntity
    {
        /// <summary>
        /// Método responsável por retornar ou setar o id
        /// </summary>
        int Id { get; set; }
    }
}
