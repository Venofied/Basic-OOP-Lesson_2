using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class BankAccount3
    {
        static long Number = 0;

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        private BankAccountType _type;

        public BankAccountType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public enum BankAccountType
        {
            Current,
            Calculated,
            Credit,
            Deposit
        }

        public BankAccount3() : this(balance: 0)
        {
            BankAccount3.RandomNumber();
        }
        public BankAccount3(decimal balance) : this(balance, BankAccountType.Credit)
        {
            BankAccount3.RandomNumber();
            Balance = balance;
        }
        public BankAccount3(decimal balance, BankAccountType accountType)
        {
            BankAccount3.RandomNumber();
            Balance = balance;
            Type = accountType;
        }

        static void RandomNumber()
        {
            Number = new Random().Next(0, int.MaxValue);
        }
        public string PrintAccount()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Номер счета: {BankAccount3.Number.ToString()}");
            sb.Append("\n");
            sb.Append($"Тип счета: {this.Type.ToString()}");
            sb.Append("\n");
            sb.Append($"Баланс: {this.Balance.ToString()}");
            return sb.ToString();
        }

        public bool WithdrawAccount(decimal balance)
        {
            if (_balance >= balance)
            {
                _balance = _balance - balance;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PutAccount(decimal balance)
        {
            _balance += balance;
        }

    }
}
