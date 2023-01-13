namespace Bank_Task.Exceptions
{
    public class NotEnoughBalanceException : ApplicationException
    {

        public NotEnoughBalanceException(string message) : base(message) {

        }
    }
}
