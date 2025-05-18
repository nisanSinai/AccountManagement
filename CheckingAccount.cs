namespace AccountManagement
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;

        public override void Withdraw(double amount)
        {
            if (this.balance + this.overdraftLimit >= amount)
            {
                this.balance -= amount;
            }
        }

        public override void PrintBalance()
        {
            Console.WriteLine($"Balance: {this.balance}, Limit: {this.overdraftLimit}");
        }

        public void SetOverdraftLimit(double limit)
        {
            this.overdraftLimit = limit;
        }

        public double GetOverdraftLimit()
        {
            return this.overdraftLimit;
        }
    }
}
