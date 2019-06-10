using System;

class IfTest
{
    public static void Main(String[] argv)
    {
        int i;
        for (i = -5; i <= 5; i++)
        {
            if (i < 0)
                Console.WriteLine("i {0} отрицательное число", i);
            else if (i == 0)
                Console.WriteLine("{0}", i + " НОЛЬ");
            else
                Console.WriteLine("{0}", i + "положительное число");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        char ch= 'A';
        for (ch = 'A'; ch < 'G'; ch++)
        switch(ch)
            {
                case 'A':
                    Console.WriteLine("CH содержит " + ch);
                    break;
                case 'B':
                    Console.WriteLine("ch содержит" + ch);
                    break;
                default:
                    Console.WriteLine("ch содержит что то другое");
                    break;
                
            }

    }
}