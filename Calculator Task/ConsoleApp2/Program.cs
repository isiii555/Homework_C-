double Plus(double a ,double b)
{
    return a + b;
}

double Mult(double a, double b)
{
    return a * b;
}

double Div(double a,double b)
{
    if (b == 0)
    {
        return 0;
    }
    return a / b;
}

double Subt(double a,double b)
{
    return a - b;   
}

Console.WriteLine("Enter first number:");
double.TryParse(Console.ReadLine(), out double num1);
Console.WriteLine("Enter second number:");
double.TryParse(Console.ReadLine(),out double num2);
Console.WriteLine("Enter symbol(/,+,-,*):");
string symbol = Console.ReadLine();


switch (symbol)
{
    case "+":
        Console.WriteLine("Result : " + Plus(num1,num2));
        break;
    case "-":
        Console.WriteLine("Result : " + Subt(num1,num2));
        break;
    case "*":
        Console.WriteLine("Result : " + Mult(num1,num2));
        break;
    case "/":
        if (Div(num1, num2) != 0)
        {
            Console.WriteLine("Result : " + Div(num1, num2));
        }
        else
            Console.WriteLine("Zero division not allowed");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}


