using Petshop.Models;
using System.Linq.Expressions;

PetShop petshop = new();
Cat pishik1 = new("wamil-pishik", 12, "erkek", 100, 200, 8);
Cat pishik2 = new("rustam-pishik", 99, "erkek", 20, 3, 12);
CatHouse ev1 = new("ehmedli-pishik-evi");
ev1.AddCat(pishik1);
ev1.AddCat(pishik2);
petshop.catHouses.Add(ev1);

void WrongChoice()
{
    Console.Clear();
    Console.WriteLine("Wrong choice,try again");
    Thread.Sleep(2000);
    Console.Clear();
}

labelmain:
Console.Clear();
for (int i = 0; i < petshop.catHouses.Count; i++)
{
    Console.WriteLine(i+1 + "." + petshop.catHouses[i].name);
}
Console.WriteLine("0.Back");


int choice = Convert.ToInt32(Console.ReadLine());

if(choice < 0 || choice > petshop.catHouses.Count)
{
    WrongChoice();
    goto labelmain;
}
else if(choice == 0){

}
else
{
labelcat:
    Console.Clear();
    for (int i = 0; i < petshop.catHouses[choice-1].cats.Count; i++)
    {
        Console.WriteLine(i + 1 + "." + petshop.catHouses[choice - 1].cats[i].nickname);
    }
    Console.WriteLine($"{petshop.catHouses[choice - 1].cats.Count + 1}.All Price\n" + $"{petshop.catHouses[choice - 1].cats.Count + 2}.All Meal Quantity\n" + "0.Back\n" + "Choose cat\n");
    int choice1 = Convert.ToInt32(Console.ReadLine());
    if (choice1 < 0 || (choice1 > petshop.catHouses[choice-1].cats.Count && choice1 != petshop.catHouses[choice - 1].cats.Count + 1 && choice1 != petshop.catHouses[choice - 1].cats.Count + 2) )
    {
        WrongChoice();
        goto labelcat;
    }
    else if(choice1 == 0)
    {
        goto labelmain;
    }
    else if(choice1 == petshop.catHouses[choice - 1].cats.Count + 1)
    {
        labelallprice:
        Console.Clear();
        double sum = default;
        for (int i = 0; i < petshop.catHouses[choice - 1].cats.Count; i++)
        {
            sum += petshop.catHouses[choice - 1].cats[i].price;
        }
        Console.WriteLine($"All price : {sum}");
        Console.WriteLine("0.Back");
        string choice3 = Console.ReadLine();
        if (choice3 != "0")
        {
            WrongChoice();
            goto labelallprice;
        }
        else
            goto labelcat;
    }
    else if(choice1 == petshop.catHouses[choice - 1].cats.Count + 2)
    {
        labelallmeal:
        Console.Clear();
        double sum = default;
        for (int i = 0; i < petshop.catHouses[choice - 1].cats.Count; i++)
        {
            sum += petshop.catHouses[choice - 1].cats[i].mealQuantity;
        }
        Console.WriteLine($"All meal quantity : {sum}");
        string choice3 = Console.ReadLine();
        if (choice3 != "0")
        {
            WrongChoice();
            goto labelallmeal;
        }
        else
            goto labelcat;
    }
    else
    {
        labelcatpersonal:
        Console.Clear();    
        Console.WriteLine("1.Play with cat\n2.Feed cat\n0.Back\n");
        string choice2 = Console.ReadLine();
        if (choice2 != "1" && choice2 != "2" && choice2 != "0")
        {
            WrongChoice();
            goto labelcatpersonal;
        }
        else if(choice2 == "0")
        {
            goto labelcat;
        }
        else if(choice2 == "1")
        {
            petshop.catHouses[choice - 1].cats[choice1 - 1].Play();
            goto labelcatpersonal;
        }
        else
        {
            petshop.catHouses[choice - 1].cats[choice1 - 1].Eat();
            goto labelcatpersonal;
        }
    }

}

