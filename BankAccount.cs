namespace AccountManagement
{
    public abstract class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public abstract void Withdraw(double amount);

        public virtual void PrintBalance()
        {
            Console.WriteLine($"Balance: {this.balance}");
        }

        public int GetAccountNumber()
        {
            return this.accountNumber;
        }

        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public Customer GetCustomerOwner()
        {
            return this.customerOwner;
        }

        public void SetCustomerOwner(Customer customer)
        {
            this.customerOwner = customer;
        }
    }
}
