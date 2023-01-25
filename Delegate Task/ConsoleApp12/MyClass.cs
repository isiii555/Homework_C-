namespace ConsoleApp12
{
    public class MyClass
    {
        public void Space(string str)
        {
            for (int i = 0; i < str.Count(); i++)
            {
                Console.Write(str[i]);
                if(i != str.Count()-1)
                    Console.Write("_");
            }
            Console.WriteLine();
        }

        public void Reverse(string str)
        {
            for (int i = str.Count()-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
