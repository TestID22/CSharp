using System;
/**
 * Шифо Цезаря ...
 */

class SystemArguments
{
    public static void Main(String[] args)
    {
        if (args.Length < 2)
            Console.WriteLine("Введите з для шифровки, вторым аргументом нужно ввести слово");

        else if (args[0] != "з" && args[0] != "д")
            Console.WriteLine("Неверно введён флаг");

        else
            for (int n = 1; n < args.Length; n++)
                for (int i = 0; i < args[n].Length; i++)
                    if (args[0] == "з")
                        Console.WriteLine((char)(args[n][i] + 1));
                    else if (args[0] == "д")
                        Console.WriteLine((char)(args[n][i] - 1));
                    else
                        foreach (String s in args)
                            Console.WriteLine(args[i]);

        Console.ReadLine(); 
    }
    
}