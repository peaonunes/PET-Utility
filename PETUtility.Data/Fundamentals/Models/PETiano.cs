using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals.Models
{
    /// <summary>
    /// Classe responsável por representar um PETiano
    /// </summary>
    public class PETiano : BaseEntity
    {
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
