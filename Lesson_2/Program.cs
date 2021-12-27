namespace Lesson_2
{
   static class Program
    {
        static void Main()
        {
            PrintBankAccount();
            PrintBankAccount2();
            PrintBankAccount3();
        }
        static void PrintBankAccount()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.SetNumber(1234);
            bankAccount.SetTypeAccount(BankAccount.BankAccountType.Deposit);
            bankAccount.SetBalance(2309990);
            Console.WriteLine(bankAccount.PrintAccount());
        }
        static void PrintBankAccount2()
        {
            BankAccount2 bankAccount2 = new BankAccount2();
            bankAccount2.PrintAccount();

            BankAccount2 bankAccount21 = new BankAccount2(232342);
            bankAccount21.PrintAccount();

            BankAccount2 bankAccount22 = new BankAccount2(231414, BankAccount2.BankAccountType.Deposit);
            bankAccount22.PrintAccount();
        }
        static void PrintBankAccount3()
        {
            BankAccount2 bankAccount2 = new BankAccount2();
            bankAccount2.PrintAccount();

            BankAccount2 bankAccount21 = new BankAccount2(232342);
            bankAccount21.PrintAccount();

            BankAccount2 bankAccount22 = new BankAccount2(231414, BankAccount2.BankAccountType.Deposit);
            bankAccount22.PrintAccount();
        }
    }
}
