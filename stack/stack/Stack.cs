using System;

class Stack
{
    //эти поля сокрыты
    char[] stck; //массив который служит нам стеком
    int tos; // индекс вершины стека

    public Stack(int size) //конструктор класса пустого стека
    {
        stck = new char[size]; // определяем размер стека и создаём объект
        tos = 0;       //индекс вершины стека.

    }

    public void Push(char ch) //поместить символ в стек принимант параметр чар
    {
        if (tos == stck.Length) //если индекс равен величине стека, то пишем Стек заполнен
        {
            Console.WriteLine(" - Стек заполннен");
            return;
        }
        stck[tos] = ch; // если стек не полон заполняем символом, который передам в параметре
        tos++; // увеличиваем индекс стека, т.к стек работает по FILO 
               //то индекс вершины стека должен увеличиваться по мере поступления в него объектов

    }
    //извлечь символ из стека
    public char Pop()
    {
        if (tos == 0) // если индекс стека равен нулю, то он пуст...лол
        {
            Console.WriteLine("Стек пуст");
            return (char)0;
        }
        tos--; //уменьшаем индекс 
        return stck[tos]; //возвращаем значение индекса
    }
    public bool IsFull()
    {
        return tos == stck.Length;
    }
    public bool IsEmpty()
    {
        return tos == 0;
    }
    //возвращает полную ёмкость стека
    public int Capacity()
    {
        return stck.Length;
    }
    public int GetNum() //возвратить текущие состояние стека
    {
        return tos;
    }

}