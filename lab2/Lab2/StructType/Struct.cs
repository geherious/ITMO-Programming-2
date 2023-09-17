namespace StructType
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }   
    internal class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.WriteLine("Введите номер аккаунта");
            if(!long.TryParse(Console.ReadLine(), out goldAccount.accNo) || goldAccount.accNo <= 0)
            {
                Console.WriteLine("Неккоректный ввод");
                return;
            }

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance {0}", goldAccount.accBal); 
        }
    }
}