namespace AccountManagement
{
    public class BankBranch : IBankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts;
        private int count;

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
            this.accounts = new CheckingAccount[20];
            this.count = 0;
        }

        public void AddAccount(CheckingAccount account)
        {
            if (this.count < this.accounts.Length)
            {
                this.accounts[this.count] = account;
                this.count++;
            }
        }


        public void PrintAccounts()
        {
            for (int i = 0; i < this.count; i++)
            {
                Console.WriteLine($"Account: {this.accounts[i].GetAccountNumber()}");
                this.accounts[i].PrintBalance();
            }
        }

        public int GetBranchNumber()
        {
            return this.branchNumber;
        }

        public void SetBranchNumber(int branchNumber)
        {
            this.branchNumber = branchNumber;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }
    }
}
