using Autofac;
using PETUtility.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PETUtility.Web.Models
{
    /// <summary>
    /// Classe responsável por carregar o container builder
    /// </summary>
    public class FlexibleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(PETUtilityContext)).As(typeof(IContext)).InstancePerLifetimeScope();
        }
    }
}