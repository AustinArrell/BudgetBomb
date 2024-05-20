namespace BudgetBomb.Models
{
    public class AccountIndexViewModel
    {
        public IEnumerable<BudgetBomb.Models.Account> accounts { get; set; }
         public string totalBalances { get; set; }
        public List<string> currentBalances { get; set; } = new List<string>();
        public int numOfAccounts { get; set; }
        public int numOfBanks { get; set; }
    }
}
