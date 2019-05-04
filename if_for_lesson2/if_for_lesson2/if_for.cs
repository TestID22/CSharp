using System;

class Learn_lesson2{
    static void Main(){
        // if (условие ) собственно как в Java, C++ и Python 
        int a, b, c;
        a = 5;
        b = 10;
        Console.WriteLine("ХЕЛЛЛОУ, Анонимус");
        if (a < b) Console.WriteLine("a меньше b");
        //не подлежит выводу
        if (a == b) Console.WriteLine("a equal b");
        c = a - 10;
        if (c <= 0) Console.WriteLine("c отрицательное число и оно равняется:\n" + c );

        //Цикл фор, функции For передаём три параметра - начальное значение, граница, инкремент
        //Переменная count выполняет роль управления цикла
        int count;
        for (count = 0; count < 10; count += 2)
        

            Console.WriteLine("Считаем  " + count);
            Console.WriteLine("Всё");
        
          
    }    
}