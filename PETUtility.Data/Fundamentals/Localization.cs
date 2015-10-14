using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals
{
    /// <summary>
    /// Classe responsável por representar as constantes globais
    /// </summary>
    public static partial class Localization
    {
        public static class Global
        {
            public const string AplicationName = "PET-Utility";
            public const string RegisterTitle = "Cadastro";
            public const string LoginTitle = "Login";

            public static class Error
            {
                public const string EnumNotFound = "Enum não encontrado";
            }
        }
    }
}
