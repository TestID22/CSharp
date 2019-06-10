using System;

class MinFinder
{
    public static void Main(string [] argv)
    {
        int[] test = new int[] { 100, 45, 236, 66, 223, 783, 35, 1276,
                                    34, 2, 365, 2, 6, 7, 8, 34, 34,};

        int num = test[0]; //алгоритмик по нахождению самого маленького значения в массиве
        foreach (int i in test) //могу собой гордиться
        {
            if (i < num)
            {
                num = i;
            }

        }
         Console.WriteLine("Самое маленькое значение в массиве равно = " + num);

    }
}