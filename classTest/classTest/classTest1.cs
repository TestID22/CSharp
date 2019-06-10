using System;



class ClassTest
{
    public static void Main(String[] argv)
    {
        SystemEcorp system = new SystemEcorp(100);
        Fsociety elliot = new Fsociety(12000, "Elliot", "Dog");
        Console.WriteLine(elliot.getName());
        elliot.PrintAnimal();
        elliot.hackSystem(system.hackMe());
    }
}


