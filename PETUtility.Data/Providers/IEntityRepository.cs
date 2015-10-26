using PETUtility.Data.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Providers
{
    public interface IEntityRepository<T> : IDisposable
         where T : BaseEntity
    {
        /// <summary>
        /// Método responsável por adicionar uma entidade no repositório
        /// </summary>
        void Create(T entity);
        /// <summary>
        /// Método responsável por remover uma entidade no repositório
        /// </summary>
        void Delete(T entity);
        /// <summary>
        /// Método responsável por atualizar uma entidade no repositório
        /// </summary>
        void Update(T entity);
    }
}
