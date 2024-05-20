using System.ComponentModel.DataAnnotations;

namespace BudgetBomb.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

    }
}
