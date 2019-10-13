using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Review");

            Console.WriteLine("ID выполняющегося потока {0}", Thread.CurrentThread.ManagedThreadId);
            BinaryOp delegateObject = new BinaryOp(Add); //Добавили метод в делегат
            //вызов делегата - подразумевает вызов всех методов внтури

            IAsyncResult asyncObject = delegateObject.BeginInvoke(5, 10, null, null);
            while (!asyncObject.IsCompleted)
            {
                Console.WriteLine("Нагрузка и расчёт");
            }
            int asyncAnswer = delegateObject.EndInvoke(asyncObject);
            Console.WriteLine("{0} - asyncResult", asyncAnswer);


            //Метод Add усыпит поток на 5 сек, поскольку он синхронный, рантайм остановится на 5 сек, и потом
            //продолжит выполнение 
            int answer = delegateObject.Invoke(5, 10);
            Console.WriteLine("Имитация бездействия - ждун");
            Console.WriteLine("{0} - result", answer);
            
            Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            Console.WriteLine("ID потока выполняющего функцию {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
