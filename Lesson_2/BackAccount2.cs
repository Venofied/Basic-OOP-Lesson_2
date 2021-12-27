using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class BankAccount2
    {
        static long Number = 0;

        private long _number = 0;
        private decimal _balance = 0;
        private BankAccountType _type = BankAccountType.Credit;
        public enum BankAccountType
        {
            Current,
            Calculated,
            Credit,
            Deposit
        }

        public BankAccount2() : this(balance: 0)
        {
            BankAccount2.RandomNumber();
        }
        public BankAccount2(decimal balance) : this(balance, BankAccountType.Credit)
        {
            BankAccount2.RandomNumber();
            _balance = balance;
        }
        public BankAccount2(decimal balance, BankAccountType accountType)
        {
            BankAccount2.RandomNumber();
            _balance = balance;
            _type = accountType;
        }
      
        static void RandomNumber()
        {
            Number = new Random().Next(0, int.MaxValue);
        }
        public string PrintAccount()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Номер счета: {BankAccount2.Number.ToString()}");
            sb.Append("\n");
            sb.Append($"Тип счета: {this._type.ToString()}");
            sb.Append("\n");
            sb.Append($"Баланс: {this._balance.ToString()}");
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
