using System;
class Code
{
   static public void Main(string[] args)
    {
        int x;
        x = 100;
        System.Console.WriteLine("Значение x " + x);
        int y;
        y = x / 2;
        System.Console.WriteLine(y);

        if (x > y) System.Console.WriteLine("X меньше");
        int[] nums = { 1, 23, 54, 7, 2};

        for (int i = 0; i < nums.Length; i++)//Length считает от 1.ГАДДЕМ, а как же ошибка на -1?
        {               
            System.Console.WriteLine("Тут числа из массива - " + nums[i]);
            if (nums[i] % 2 != 0)
                System.Console.WriteLine("Число " + nums[i] + " нечётное, ok? cool");
        }
        System.Console.WriteLine();
        double r = System.Math.Sqrt(47.00000);
        System.Console.WriteLine(r);
        System.Console.WriteLine();
        char c = '\n';
        System.Console.WriteLine(c);
        Console.WriteLine();
        //работа спецификаторов {0} 
        Console.WriteLine("Икарди носит номер {0} , а Милито носил номер {1}", 8, 22);
        Console.WriteLine();
        int j;
        for (j = 0; j < 10; j++) 
            Console.WriteLine("Число {0, 2}, квадрат {1, 2}, куб{2, 2} ", j, j * j, j * j * j);
        Console.WriteLine();
        Console.WriteLine(@"Пообие трёх апострофов в Питоне
    ## e e eeee
    #  eee e  e
    ##   e e  e
                ");
           
    }
}