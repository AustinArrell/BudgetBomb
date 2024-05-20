using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BudgetBomb.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        [DisplayName("Current Balance")]
        public float CurrentBalance { get; set; }
        public string Owner { get; set; }
        [DisplayName("Bank Name")]
        public string BankName { get; set; }

    }
}
