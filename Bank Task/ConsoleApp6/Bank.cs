namespace Bank_Task
{
    public class Bank
    {
        public List<Client> clients = new();

        public void ShowCardBalance(BankCard bankCard)
        {
            Console.WriteLine($"Balance : {bankCard}");
        }

        public void AddUser(Client client)
        {
            clients.Add(client);
        }
    }
}
