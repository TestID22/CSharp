using System;

class Test
{
    public static void Main(string[] argv)
    {
        
        string name = Console.ReadLine();
        
        for (int i = name.Length -1; i < name.Length; i--)
            Console.Write(name[i]);

        
    }
}