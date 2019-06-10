using System;

class CopyArrayTest
{
    public static void Main(String[] argv)
    {
        int[] inter = new int[10];
        int[] milan = new int[10];
        int i, j;
        //Инициализируем массив Интер
        for (i = 1; i < inter.Length; i++)
        {
            inter[i] = i;
            //Console.WriteLine(inter[i]); worked
        }
        //Если второй массив не меньше первого
        if (milan.Length >= inter.Length)
        {
            for (i = 1, j = inter[0]; i < inter.Length; i++, j++)//То устанавливаем индексы по массивам       
                milan[j] = inter[i];                             // даём условие, чтоб пройтись по массиву, и итерацию задаём

        }
        for(j=0; j < milan.Length; j++)
        Console.WriteLine(milan[j]);
    }
}