using Animals;

public class Farm
{
    public static void Main()
    {
        IAnimal dog = new Dog("Buddy",3);
        IAnimal cat = new Cat("Whiskers", 2);

        List<IAnimal> framAnimals = new List<IAnimal>();

        Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
        dog.MakeSound(); // Output: Woof!
        dog.Move();      // Output: The dog runs.

        Console.WriteLine($"{cat.Name} is {cat.Age} years old.");
        cat.MakeSound(); // Output: Meow!
        cat.Move();      // Output: The cat sneaks.
    }
}