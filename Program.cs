using Module17.Accounts;
using Module17.Properties;

namespace Module17;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Account> accounts = new()
        {
            new RegularAccount() {Balance = 500},
            new RegularAccount() {Balance= 2000},
            new RegularAccount() {Balance = 100000},
            new SalaryAccount() {Balance = 40000},
            new SalaryAccount() {Balance = 35000}
        };
        
        foreach (var account in accounts)
        {
            DisplayAccountInfo(account);
        }
        Console.ReadKey();
    }

    private static void DisplayAccountInfo(Account account)
    {
        Console.WriteLine("----------");
        Console.WriteLine($"{Resources.AccountType}: {account.TypeName}");
        Console.WriteLine($"{Resources.Balance}: {account.Balance}");
        Console.WriteLine($"{Resources.Interest}: {account.CalculateInterest()}");
        Console.WriteLine();
    }
}