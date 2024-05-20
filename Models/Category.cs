using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BudgetBomb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [AllowNull]
        public string Type { get; set; }
        [AllowNull]
        public string Description { get; set; }
        [AllowNull]
        public float BudgetAmount { get; set; } = 0;
    }
}
