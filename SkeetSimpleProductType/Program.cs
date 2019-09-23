using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeetSimpleProductType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            ConsoleColor prevColor1 = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сортировки--------------------------");
            Console.ForegroundColor = prevColor1;

            List<Product> ListOfProducts = Product.GetSampleProducte();
            Console.WriteLine("Список Продуктов до сортировки");
            foreach(Product p in ListOfProducts)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            //Пример Сортировки с использованием класса и имплементации Интерфейса
            ListOfProducts.Sort(new ProductComparer());
            Console.WriteLine("Список после нашей сортировки");
            foreach(Product p in ListOfProducts)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            List<Product> ListOfProducts1 = Product.GetSampleProducte();
            //пример сортировки с делегатом
            ListOfProducts.Sort(delegate (Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            });

            
            List<Product> ListOfProducts2 = Product.GetSampleProducte();
            //пример сортировки с лябдой
            ListOfProducts.Sort((x, y) => x.Name.CompareTo(y.Name));

            List<Product> ListOfProducts3 = Product.GetSampleProducte();
            //пример вывода с расширяющим методом
            foreach (Product product in ListOfProducts.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Запрашиваие данных ----------------------------------");
            Console.ForegroundColor = prevColor1;

            //Запрашиавние данных в C#1 
            List<Product> list = Product.GetSampleProducte();
            foreach(Product p in list)
            {
                if(p.Price > 10)
                {
                    Console.WriteLine(p);
                }
            }

            Console.WriteLine();
            //Запрашиване данных в C# делегаты

            List<Product> list1 = Product.GetSampleProducte();
            Predicate <Product> test = delegate (Product p ){ return p.Price < 10; };
            List<Product> listDelegate = list1.FindAll(test);
            Action<Product> print = Console.WriteLine;
            listDelegate.ForEach(print);


            Console.WriteLine();
            //запрашивание с помощью лямбды

            List<Product> list2 = Product.GetSampleProducte();
            foreach(Product p in list2.Where(p => p.Price > 11))
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            //запрашивание данных LINQ
            List<Product> list3 = Product.GetSampleProducte();
            var result = from Product p in list3 where p.Price < 10 select p;
            foreach(var r in result)
            {
                Console.WriteLine(r);
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
