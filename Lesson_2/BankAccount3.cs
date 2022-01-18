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
        public static bool MoneyTransfer(ref BankAccount3 WriteOffAccount, ref BankAccount3 СreditAccount, decimal Sum)
        {
            if (WriteOffAccount.Balance > Sum)
            {
                decimal TmpSum = WriteOffAccount.Balance - Sum;
                СreditAccount.Balance += TmpSum;
                return true;
            }
            else return false;
        }
        public static string TaskString(string line)
        {
            if (line == string.Empty || line is null)
            {
                return string.Empty;
            }
            else
            {
                string Tmpline = string.Empty;
                for (int i = line.Length - 1; i > 0; i--)
                {
                    Tmpline += line[i];
                }
                return Tmpline;
            }
        }

        public static void SearchMail(ref string s)
        {
            int CountEmails = s.Split('\u0026').Count();
            string[] tmp = new string[CountEmails];
            tmp = s.Split('\u0026');

            s = string.Empty;
            for (int i = 0; i < CountEmails; i++)
            {
                bool resultFind = tmp[i].Contains("@");
                if (!resultFind)
                {
                    tmp[i] = String.Empty;
                }
                else
                {
                    int SubCount = tmp[i].Split(" ").Count();
                    if (SubCount > 1)
                    {
                        string[] SubTmp = new string[SubCount];
                        SubTmp = tmp[i].Split(" ");
                        for (int j = 0; j < SubCount; j++)
                        {
                            if (SubTmp[j].Any())
                            {
                                if (SubTmp[j].Contains("@"))
                                {
                                    s += SubTmp[j];
                                    s += ";";
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
