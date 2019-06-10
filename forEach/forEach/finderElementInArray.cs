using System;

class Finder
{
    public static void Main(String[] argv)
    {
        int[] test = new int[] { 1, 100, 5, 3, 7, 455, 23, 59 };

        int var; // число которое мы ищем
        bool result = false;
        var = 23;
        int count = 0;
        foreach (int i in test)
        {
            count++; //счётчик итераций, нужен для подчсёта элемета в массиве
      
            if (i == var)
                break;
            result = true;
        }
        if (result)
        {
            Console.WriteLine("Мы нашли число, оно оказалось {0} по списку" , count );
        }
    } 
      
}