using System;

public class Fsociety
{
    public int sallary = 1200;
    private string name = "Hacker";
    private string animal = "dog";

    public Fsociety(int sallary, string name, string animal)
    {
        this.sallary = sallary;
        this.name = name;
        this.animal = animal;
    }
    public string getName()
    {
        return name;
    }
    public void PrintAnimal()
    {
        Console.WriteLine(animal);
    }
    //метод который обращается к объекту класса система
}