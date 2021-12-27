using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class BankAccount
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
        public BankAccountType GetTypeAccount()
        {
            return _type;
        }
        public void SetTypeAccount(BankAccountType type)
        {
            _type = type;
        }
        public long GetNumber()
        {
            return _number;
        }
        public void SetNumber(long number)
        {
            _number = number;
        }
        public decimal GetBalance()
        {
            return this._balance;
        }
        public void SetBalance(decimal balance)
        {
            _balance = balance;
        }
        static void RandomNumber()
        {
            Number = new Random().Next(0, int.MaxValue);
        }
        public string PrintAccount()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Номер счета: {this.GetNumber().ToString()}");
            sb.Append("\n");
            sb.Append($"Тип счета: {this.GetTypeAccount().ToString()}");
            sb.Append("\n");
            sb.Append($"Баланс: {this.GetBalance().ToString()}");
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
