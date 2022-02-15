using Lesson_2.Lesson_6;

namespace Lesson_2
{
   static class Program
    {
        static void Main()
        {
            PrintBankAccount3();
        }
        static void PrintBankAccount3()
        {
            // 1 задание

            BankAccount3 bankAccountMain = new BankAccount3(231414, BankAccount3.BankAccountType.Deposit);
            bankAccountMain.PrintAccount();

            BankAccount3 bankAccountSub = new BankAccount3(222331, BankAccount3.BankAccountType.Deposit);
            bankAccountMain.PrintAccount();

            BankAccount3.MoneyTransfer(ref bankAccountMain, ref bankAccountSub, 31244);

            string result = BankAccount3.TaskString("Простое предложение");

            string s = "Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru";

            BankAccount3.SearchMail(ref s);

            // 2 задание
            Console.Clear();

            //Circle circle = new Circle(6, 6);

            Rectangle rectangle = new Rectangle(4, 5);


        }
    }
}
