using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PETUtility.Data.Fundamentals.Models;

namespace PETUtility.Data.Context
{
    /// <summary>
    /// Contrato responsável pelas entidades do banco de dados (contexto)
    /// </summary>
    public interface IContext : IDisposable
    {
        IDbSet<PETiano> PETianos { get; set; }

        /// <summary>
        /// Setar o banco de dados
        /// </summary>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
}
