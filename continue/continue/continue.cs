using System;

class ContinueTest
{
    public static void Main(String[] argv)
    {
        
        for (int i = 0; i <= 100; i++)
        {
            if ((i % 2) != 0) continue; /*условие гласит, что если остаток от деления по модулю
                                          не равен нулю, то мы пропускаем выполнение интсрукции
                                        */
            Console.WriteLine(i);
        }
    }
}