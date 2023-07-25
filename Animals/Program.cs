using Animals;

Console.Write("Input dog name: "); 
var name = Console.ReadLine();
var dog = new Dog();
dog.SetName(name);
Console.WriteLine(dog.GetName());
dog.Eat();
