using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndCallBack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Account acc = new Account(1000);

            //Регистрация нового делегата через метод
            acc.RegisterHandler(new Account.DelegateMoney(Show_Msg));
            //GetMoney - метод в котором определена работа делегата.
            acc.GetMoney(200);
            acc.GetMoney(1000);
            acc.ShowMoney();


            Console.WriteLine();
            Console.ReadLine();
        }

            

        static void Show_Msg(string msg)
        {
            Console.WriteLine(msg);
            
        }
    }
}
