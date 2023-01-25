namespace ConsoleApp12
{
    public class Run
    {
        public void runFunc(Action<string> del,string str) {
            del.Invoke(str);
        }

    }
}
