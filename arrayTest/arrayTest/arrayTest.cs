using System;

class ArrayTest
{
    public static void Main(String[] argv)
    {
        int[] interNums;
        interNums = new int[10] { 4, 1, 5, 17, 434, 5, 80, 98, 41, 11 };
        int[] inter = new int[10] { 4, 1, 5, 17, 434, 5, 80, 98, 41, 11 };
        int i;
        //Инициализированный массив перепишем в десятки
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(interNums[i]);
            interNums[i] = 10;
        }
        // Выведем десятки массива
        for (i = 0; i < interNums.Length; i++)
            Console.WriteLine("Теперь в массиве {0} ", i + interNums[i]);

        Console.WriteLine();
        //найдём среднее арифметическое второго массива
        int sum = 0;
        for (i = 0; i < inter.Length; i++)
        {
            Console.WriteLine(sum += inter[i]);
        }
        int avg; avg = sum / 10;
        Console.WriteLine("Среденее аримфетическое {0}" ,avg);
        
    }
}