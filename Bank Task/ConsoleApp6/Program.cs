using Bank_Task;
using Bank_Task.Exceptions;

Client islam = new Client("Islam","Salamzade", new BankCard("ArmudBank", "Islam Salamzade", "2888910282789079", "3131", "316", "01/26", 23000));

Client namik = new Client("Namik", "Rasullu", new BankCard("ArmudBank", "Namik Rasullu", "7356105338013631", "2121", "613", "01/32", 300));

Client rustam = new Client("Rustam", "Mammadov", new BankCard("ArmudBank", "Rusik Mammadov", "0210686896019021", "4141", "621", "01/31", 2));

Client wamil = new Client("Vvamil", "Nabizade", new BankCard("ArmudBank", "Vvamil Nabizade", "4328115008968325", "5151", "789", "01/28", 1200));

Client elcin = new Client("Elcin", "Guliyev", new BankCard("ArmudBank", "Elcin Guliyev", "9935871614872265", "8181", "987", "01/48", 32000));

Bank bank = new Bank();
bank.AddUser(islam);
bank.AddUser(namik);        
bank.AddUser(rustam);
bank.AddUser(wamil);
bank.AddUser(elcin);

bool CheckBalance(decimal num,decimal balance)
{
    if (balance >= num)
    {
        return true;
    }
    return false;
}
void Main()
{
labelmain:
    Console.Clear();
    Console.WriteLine("Enter pin : ");
    string? pin = Console.ReadLine();
    for (int i = 0; i < bank.clients.Count; i++)
    {
        if (pin == bank.clients[i].creditCard.Pin)
        {
        labelchoice:
            Console.Clear();
            Console.WriteLine($"Welcome , {bank.clients[i].Name} {bank.clients[i].Surname}");
            Console.WriteLine("1.Balance\n2.Cash\n3.CardToCard\n0.Back");
            Console.WriteLine("Please enter your choice :");
            string? choice = Console.ReadLine();
            if (choice == "1")
            {
            labelbalance:
                Console.Clear();
                bank.clients[i].ShowBalance();
                Console.WriteLine("0.Back");
                choice = Console.ReadLine();
                if (choice != "0")
                {
                    Console.WriteLine("Wrong Choice,try again");
                    goto labelbalance;
                }
                else
                    goto labelchoice;
            }
            else if (choice == "2")
            {
            labelcash:
                Console.Clear();
                Console.WriteLine("1.10 $");
                Console.WriteLine("2.20 $");
                Console.WriteLine("3.50 $");
                Console.WriteLine("4.100 $");
                Console.WriteLine("5.Other $");
                Console.WriteLine("0.Back");
                choice = Console.ReadLine();
                if (Convert.ToInt32(choice) < 0 || Convert.ToInt32(choice) > 5)
                {
                    Console.WriteLine("Wrong Choice,try again");
                    goto labelcash;
                }
                else if (choice == "1")
                {
                    if (CheckBalance(10, bank.clients[i].creditCard.Balance))
                    {
                        bank.clients[i].creditCard.Balance -= 10;
                        Console.WriteLine("Success...");
                        Thread.Sleep(1000);
                        goto labelchoice;
                    }
                    throw new NotEnoughBalanceException("Not enough balance!");
                }
                else if (choice == "2")
                {
                    if (CheckBalance(20, bank.clients[i].creditCard.Balance))
                    {
                        bank.clients[i].creditCard.Balance -= 20;
                        Console.WriteLine("Success...");
                        Thread.Sleep(1000);
                        goto labelchoice;
                    }
                    throw new NotEnoughBalanceException("Not enough balance!");
                }
                else if (choice == "3")
                {
                    if (CheckBalance(50, bank.clients[i].creditCard.Balance))
                    {
                        bank.clients[i].creditCard.Balance -= 50;
                        Console.WriteLine("Success...");
                        Thread.Sleep(1000);
                        goto labelchoice;
                    }
                    throw new NotEnoughBalanceException("Not enough balance!");
                }
                else if (choice == "4")
                {
                    if (CheckBalance(100, bank.clients[i].creditCard.Balance))
                    {
                        bank.clients[i].creditCard.Balance -= 100;
                        Console.WriteLine("Success...");
                        Thread.Sleep(1000);
                        goto labelchoice;
                    }
                    throw new NotEnoughBalanceException("Not enough balance!");
                }
                else if (choice == "5")
                {

                    Console.WriteLine("Enter amount of money");
                    decimal money = Convert.ToDecimal(Console.ReadLine());
                    if (CheckBalance(money, bank.clients[i].creditCard.Balance))
                    {
                        bank.clients[i].creditCard.Balance -= money;
                        Console.WriteLine("Success...");
                        Thread.Sleep(1000);
                        goto labelchoice;
                    }
                    throw new NotEnoughBalanceException("Not enough balance!");
                }
                else
                    goto labelchoice;
            }
            else if (choice == "3")
            {
            labelcardtocard:
                Console.Clear();
                Console.WriteLine("Enter pan 16 digits(0.Back)");
                choice = Console.ReadLine();
                if (choice != "0")
                {
                    for (int j = 0; j < bank.clients.Count; j++)
                    {
                        if (choice == bank.clients[j].creditCard.Pan)
                        {
                            Console.WriteLine($"To : {bank.clients[j].creditCard.fullName} ");
                            Console.WriteLine("Enter amount of money ");
                            decimal money = Convert.ToDecimal(Console.ReadLine());
                            if (CheckBalance(money, bank.clients[i].creditCard.Balance))
                            {
                                bank.clients[j].creditCard.Balance += money;
                                bank.clients[i].creditCard.Balance -= money;
                                Console.WriteLine("Success...");
                                Thread.Sleep(1000);
                                goto labelchoice;
                            }
                            throw new NotEnoughBalanceException("Not enough balance!");
                        }
                    }
                    Console.WriteLine("User not found with this pan");
                    Thread.Sleep(1000);
                    goto labelcardtocard;
                }
                else
                    goto labelchoice;
            }
            else
                goto labelmain;
        }
    }
    Console.WriteLine("User was not found with this pin,try again");
    Thread.Sleep(1000);
    goto labelmain;
}

try
{
    Main();
}
catch(Exception ex)
{
    Console.Clear();
    Console.WriteLine(ex.Message);
}
