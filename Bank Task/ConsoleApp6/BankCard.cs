namespace Bank_Task
{
    public class BankCard
    {
        public BankCard(string bankName, string fullName, string pan, string pin, string cVV, string expireDate, decimal balance)
        {
            this.bankName = bankName;
            this.fullName = fullName;
            Pan = pan;
            Pin = pin;
            CVV = cVV;
            this.expireDate = expireDate;
            Balance = balance;
        }

        public string bankName { get; set; }

        public string fullName { get; set; }

        public string Pan { get; set; }

        public string Pin { get; set; }

        public string CVV { get; set; }   

        public string expireDate { get; set; } 

        public decimal Balance { get; set; }    


    }
}
