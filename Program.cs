namespace AccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // יצירת לקוח
            Customer cust = new Customer();
            cust.SetId(1);
            cust.SetName("Ron");
            cust.SetPhoneNumber(0529876543);

            cust.PrintDetails();

            // יצירת חשבון עו"ש
            CheckingAccount acc = new CheckingAccount();
            acc.SetAccountNumber(2001);
            acc.SetBalance(800);
            acc.SetOverdraftLimit(150);
            acc.SetCustomerOwner(cust);

            acc.Deposit(100);       // עכשיו 900
            acc.Withdraw(950);      // מותר בזכות מסגרת 150

            acc.PrintBalance();

            Console.WriteLine($"Customer phone: {acc.GetCustomerOwner().GetPhoneNumber()}");

            // יצירת סניף בנק
            BankBranch branch = new BankBranch(3, "HaShalom 12");
            branch.AddAccount(acc);

            Console.WriteLine($"Branch number: {branch.GetBranchNumber()}, Address: {branch.GetAddress()}");

            // הדפסת כל החשבונות
            branch.PrintAccounts();
        }
    }
}
