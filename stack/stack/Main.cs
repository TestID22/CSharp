using System;
class StackDemo
{
    public static void Main()
    {
        Stack stk1 = new Stack(10); //создаём 3 объекта класса стек с параметро 10, который отвечает за размер стека
        Stack stk2 = new Stack(10);
        Stack stk3 = new Stack(10);
        char ch;
        int i;


    //поместим символы в стек
        for (i=0; !stk1.IsFull(); i++)
            stk1.Push((char) ('A' + i));

    //когда стек заполнен выведем оповещение
        if (stk1.IsFull())
            Console.WriteLine("Стек заполнен");

    //выведем содержимое стека
        Console.WriteLine("Содержимое стека stk1 - ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop(); //удаляет по симолу из стека
                Console.Write(ch);
            }

    //когда стек опустошится вывести сообщение
        Console.WriteLine();
            if (stk1.IsEmpty()) Console.WriteLine("Стек stkl ПУСТ");

        Console.WriteLine("Заполнить стек stk1 вновь");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

        Console.WriteLine("перенесё симолы из стека 1 в стек 2");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                stk2.Push(ch);
            }

        Console.WriteLine("Выведем содержимое стека 2");
            while(!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }
        Console.WriteLine();
        Console.WriteLine("Поместим пять элементов в стек3");
        for (i = 0; i < 5; i++)
        {
            stk3.Push((char)('A' + i));
        }
        Console.WriteLine("Ёмость стека stk3 :" + stk3.Capacity());
        Console.WriteLine("Количество объектов в stk3 :" + stk3.GetNum());
        Console.WriteLine("Содержание стека 3");
        while(!stk3.IsEmpty())
        {
            ch = stk3.Pop();
            Console.WriteLine(ch);
        }
            
    }



}