using System;

class ForTricks
{
    public static void Main(String[] argv)
    {

        int sum = 0;
        for (int i = 0; i <= 100; sum += i++) ; //тело цикла отсутствует, цикл решается в "уме"
        Console.WriteLine("Сумма равна" + sum);
        int j = 100;
        for (j = 100; j >= 0; j--) { 
            if (j < 50) break;
            Console.WriteLine("на 50 остановлюсь" + j);
        }
        
    }
}