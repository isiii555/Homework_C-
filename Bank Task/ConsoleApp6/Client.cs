namespace Bank_Task
{
    public class Client
    {
        public Client(string name, string surname, BankCard creditCard)
        {
            Name = name;
            Surname = surname;
            this.creditCard = creditCard;
        }

        public string Name { get; set; }

        public string Surname { get; set; } 

        public BankCard creditCard { get; set; }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance : {creditCard.Balance}");
        }

        
    }
}
