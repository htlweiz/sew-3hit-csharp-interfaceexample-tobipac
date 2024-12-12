namespace Animals;

public class Cat : IAnimal
{
    public string Species { get{ return "Cat";} }

    public string Name { get;  set; }
    public int Age { get;  set; }

    public Cat(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string MakeSound()
    {
        return "Meow!";
    }

    public string Move()
    {
        return "The dog sneaks.";
    }
}