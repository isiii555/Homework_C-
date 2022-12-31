using System;
using System.Collections.Specialized;
using System.Drawing;

string[] questions = { "Avropanin en boyuk valyutasi hansidir?",
                       "Azerbaycanin paytaxti hansi seherdir?",
                       "Bu heyvanlardan hansi qurbanini bogaraq oldurur?",
                       "Mektebe geden ve ya imtahan giren sagirde hansi arzunu dileyirler?",
                       "Neyin lepesini yemirler?",
                       "Shovket Elekberovanin ifa etdiyi mahnida hansi ag xalatli peshe sahiblerinden behs olunur?",
                       "Hansi ev qusu 'zengli saat' rolunu oynayir?",
                       "Hansi soz yapon dilinden tercumede muqeddes kulek menasini verir?",
                       "Badminton oyunu hansi oyuna benzeyir?",
                       "Cox melumatli adami el arasinda ne adlandirirlar?"
                       };

string[][] answers = new string[10][];
answers[0] = new string[4] { "Lira", "Rubl", "Manat", "Euro" };
answers[1] = new string[4] { "Baki", "Gence", "Masalli", "Sheki" };
answers[2] = new string[4] { "Pisik", "Anaconda", "Fil", "Qoyun" };
answers[3] = new string[4] { "Allah beterinden saxlasin", "Allah zehin acigligi versin", "Allah komeyin olsun", "Allah xoshbext elesin" };
answers[4] = new string[4] { "Qoz", "Deniz", "Badam", "Findiq" };
answers[5] = new string[4] { "Muellimler", "Hekimler", "Muhendisler", "Jurnalistler" };
answers[6] = new string[4] { "Toyuq", "Qaz", "Ordek", "Xoruz" };
answers[7] = new string[4] { "Tornado", "Tayfun", "Sunami", "Kamikadze" };
answers[8] = new string[4] { "Qolf", "Qilincoynatma", "Handbol", "Tennis" };
answers[9] = new string[4] { "Qelender", "Gulenber", "Bilender", "Culender" };

string[] canswers = { "Euro",
                      "Baki",
                      "Anaconda",
                      "Allah zehin acigligi versin",
                      "Deniz",
                      "Hekimler",
                      "Xoruz",
                      "Kamikadze",
                      "Tennis",
                      "Bilender"
};

string answer1;
string answer2;
string answer3;
string answer4;

void DeleteElementFromArray(ref string[] arr,int index)
{
    string[] temp = new string[arr.Length-1];
    for (int i = 0; i < index; i++)
    {
        temp[i] = arr[i];
    }
    for (int i = index; i < arr.Length-1; i++)
    {
        temp[i] = arr[i+1];
    }
    arr = temp;
}
void CorrectAnswer(ref int point)
{
    Console.Clear();
    point += 10;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Correct Answer");
    Thread.Sleep(1000);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;

}
void FalseAnswer(ref int point)
{
    Console.Clear();
    point -= 10;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("False Answer");
    Thread.Sleep(1000);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowPoint(int point)
{
    if (point >= 0)
    {
        Console.WriteLine("Your point : " + point);
    }
    else
        Console.WriteLine("Your point : " + 0);
}

int point = 0;
Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + 1 + "." + questions[i]);
    int j = rand.Next(0, answers[i].Length-1);
    answer1 = answers[i][j];
    DeleteElementFromArray(ref answers[i],j);
    Console.WriteLine("A)" + answer1 );
    j = rand.Next(0, answers[i].Length - 1);
    answer2 = answers[i][j];
    DeleteElementFromArray(ref answers[i], j);
    Console.WriteLine("B)" + answer2);
    j = rand.Next(0, answers[i].Length - 1);
    answer3 = answers[i][ j];
    DeleteElementFromArray(ref answers[i], j);
    Console.WriteLine("C)" + answer3);
    j = rand.Next(0, answers[i].Length - 1);
    answer4 = answers[i][j];
    DeleteElementFromArray(ref answers[i], j);
    Console.WriteLine("D)" + answer4);
    Console.WriteLine("Press buttons(A/B/C/D)");
    ShowPoint(point);
labelquestion:
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.A)
    {
        if (answer1 == canswers[i])
        {
            CorrectAnswer(ref point);
        }
        else
            FalseAnswer(ref point);
    }
    else if (key.Key == ConsoleKey.B)
    {
        if (answer2 == canswers[i])
        {
            CorrectAnswer(ref point);
        }
        else
            FalseAnswer(ref point);
    }
    else if (key.Key == ConsoleKey.C)
    {
        if (answer3 == canswers[i])
        {
            CorrectAnswer(ref point);
        }
        else
            FalseAnswer(ref point);
    }
    else if (key.Key == ConsoleKey.D)
    {
        if (answer4 == canswers[i])
        {
            CorrectAnswer(ref point);
        }
        else
            FalseAnswer(ref point);
    }
    else
    {
        goto labelquestion;
    }
}

Console.WriteLine("Exam is finished!");
Console.WriteLine("Your point : " + point);




