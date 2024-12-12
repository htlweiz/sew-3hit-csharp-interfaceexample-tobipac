namespace Animals;

public class Dog : IAnimal
{
    public string Species { get{ return "Cat";} }

    public int Age { get;  set; }
    public string Name { get;  set; }

    public Dog(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string MakeSound()
    {
        return "Woof!";
    }

    public string Move()
    {
        return "The dog runs.";
    }
}