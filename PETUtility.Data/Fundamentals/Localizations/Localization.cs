using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals.Localizations
{
    /// <summary>
    /// Classe responsável por representar as constantes globais
    /// </summary>
    public static partial class Localization
    {
        public static class Global
        {
            public const string AplicationName = "PET-Utility";

            public static class Error
            {
                public const string EnumNotFound = "Enum não encontrado";
                public const string LoginFail = "Login ou senha inválido";
            }

            public static class Menu
            {
                public const string Register = "Cadastro";
                public const string Login = "Login";
                public const string LoginOff = "LoginOff";
                public const string Activities = "Atividades";
                public const string Board = "Board";
                public const string Calendar = "Calendário";
                public const string CreatePoster = "Criar cartaz";
                public const string History = "Histórico";
                public const string Financial = "Financeiro";
                public const string Payments = "Pagamentos";
                public const string Notifications = "Notificações";
                public const string Meeting = "Reunião";
                public const string Record = "Atas";
                public const string RecordComment = "Comentários de ata";
                public const string PointsOfGuidelines = "Pontos de pautas";
                public const string Feedback = "Feedback";
                public const string Ideas = "Ideias";
            }
        }
    }
}
