using PETUtility.Data.Fundamentals.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Context
{
    /// <summary>
    /// CLasse responsável pelo contexto do banco de dados
    /// </summary>
    public class PETUtilityContext : DbContext, IContext, IDisposable
	{
        public PETUtilityContext()
            : base("PETUtilityContext")
		{
		}

        public IDbSet<PETiano> PETianos { get; set; }
        public IDbSet<Idea> Ideas { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			base.OnModelCreating(modelBuilder);
		}

		public void Dispose()
		{
			this.Dispose(true);
		}

        public System.Data.Entity.DbSet<PETUtility.Data.Fundamentals.Models.IdeaViewModel> IdeaViewModels { get; set; }
	}
}
