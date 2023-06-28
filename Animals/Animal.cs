namespace Animals;

public abstract class Animal
{
    string Name;
    
    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog Eat");
    }
}