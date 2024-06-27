using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; } = string.Empty;
        [Column(TypeName = "decimal(5,2)")]
        public decimal AccountBalance { get; set; }
    }
}
