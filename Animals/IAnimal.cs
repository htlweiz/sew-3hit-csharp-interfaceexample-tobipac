namespace Animals;

public interface IAnimal
{
    string Species { get;  }
    string Name { get; protected set; }
    int Age { get; protected set; }

    string MakeSound();
    
    string Move();
}
