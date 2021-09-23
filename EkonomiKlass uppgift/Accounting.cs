using System.Collections.Generic;

namespace EkonomiKlass_uppgift
{
    public class Accounting
    {
        public List<Account> Transactions { get; set; } = new List<Account>();
        public Dictionary<int, string> ChartOfAccounts = new Dictionary<int, string>();

        public Accounting()
        {
            ChartOfAccounts.Add(1910, "Kassa");
            ChartOfAccounts.Add(1930, "Företagskonto");
            ChartOfAccounts.Add(2440, "Leverantörsskuld");
            ChartOfAccounts.Add(3010, "Försäljning");
            ChartOfAccounts.Add(5410, "Datorinköp");
        }
        
        public void CreateTransaction(int accountNr, string label, double debit, double credit)
        {
            Transactions.Add
            (
            new Account
            {
                Number = accountNr,
                Label = ChartOfAccounts[accountNr],
                debit = debit,
                credit = credit
            });
        }
    }
}   