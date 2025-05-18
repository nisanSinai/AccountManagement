namespace AccountManagement
{
    public class Customer
    {
        private int id;
        private string name;
        private int phoneNumber;

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {this.id}, Name: {this.name}, Phone: {this.phoneNumber}");
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetPhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
