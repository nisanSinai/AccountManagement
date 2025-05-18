namespace AccountManagement
{
    public interface IBankBranch
    {
        void AddAccount(CheckingAccount account);
        void PrintAccounts();
        int GetBranchNumber();
        void SetBranchNumber(int branchNumber);
        string GetAddress();
        void SetAddress(string address);
    }
}