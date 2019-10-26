using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndCallBack
{
    class Account
    {
        //создали сигнатуру делегата
        public delegate void DelegateMoney(string message);
        //создали переменную типа делегата.
        DelegateMoney delegateMoney;

        //создали метод регистрирующий делегат
        public void RegisterHandler(DelegateMoney delegateMoney)
        {
            this.delegateMoney = delegateMoney;
        }

        public int Money { get; set; }

        public Account(int money)
        {
            this.Money = money;
        }

        public void ShowMoney()
        {
            Console.WriteLine("Денежек на счету : {0}", Money);
        }

        public void GetMoney(int sum)
        {
            if (sum <= Money)
            {
                Money -= sum;
                if (delegateMoney != null)
                {
                    delegateMoney($"Cнята сумма {sum}");
                    Console.WriteLine($"Остаток {Money}");
                }
            }
            else
            {
                Console.WriteLine($"Вы пытаетесь снять {sum},\nВаш Баланс {Money}");
                delegateMoney($"Вам не хватает {Math.Abs(Money - sum)}");
            }
        }


    }
}
