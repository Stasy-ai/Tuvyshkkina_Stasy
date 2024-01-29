using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    internal class bank_account
    {
        public enum AccountType { Debit, Credit }

        static int debitAccountsCount = 0;
        static int creditAccountsCount = 0;

        public double balance { get; private set; }
        public string AccountNumber { get; private set; }
        public AccountType Type { get; private set; }

        public bank_account(string accountNumber, AccountType type = AccountType.Debit)
        {
            if (accountNumber.Length != 6)
            {
                Console.WriteLine("Номер счета должен содержать 6 цифр");
            }
            AccountNumber = accountNumber;
            Type = type;
            if (type == AccountType.Debit)
            {
                debitAccountsCount++;
            }
            else
            {
                creditAccountsCount++;
            }
        }

        public void Deposit(double amount)
        {
            if (amount >= 1000)
            {
                balance += amount;
                Console.WriteLine($"Счет {AccountNumber} пополнен на сумму {amount}. Баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть не менее 1000р");
            }
        }

        public void Withdrawal(double amount)
        {
            if (Type == AccountType.Credit)
            {
                balance -= amount;
                Console.WriteLine($"Счет {AccountNumber} снятие суммы {amount}. Баланс: {balance}");
            }
            else
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Счет {AccountNumber} снятие суммы {amount}. Баланс: {balance}");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств на счете");
                }
            }
        }

        public static void GetAccountStats()
        {
            Console.WriteLine($"Дебетовых счетов: {debitAccountsCount}, Кредитных счетов: {creditAccountsCount}");
        }
    }
}