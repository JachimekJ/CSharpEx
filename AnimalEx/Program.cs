//Create a base class called Animal and two derived classes Dog and Cat.
//This introduces you to the concept of inheritance, where Dog and Cat inherit properties and methods from Animal.

using System;
using Microsoft.VisualBasic;


//Introduce interfaces to define a contract that classes can implement.
// Interfaces allow us to specify a set of methods that different classes must have.

//Above any existing classes in Program.cs, define an interface called IAnimal with a method Eat.
//Implement this interface in the Animal class and provide an implementation in the Dog and Cat classes.

public interface IAnimal
{
    void Eat();
}

//Above any existing classes in Program.cs, create a  Program class.
public class Program
 {
    //In the Program class, create a Main method.
    public static void Main(string[] args)
    {
    //In the Main method, create instances of the Dog and Cat classes
    // and then call the MakeSound method from instances of Dog and Cat.  
    Animal myDog = new Dog();
    Animal myCat = new Cat();

    List<Animal> animals = new List<Animal>();
    animals.Add(myDog);
    animals.Add(myCat);

    //Iterate through the list of animals and call the MakeSound method on each animal.
    foreach (var animal in animals)
    {
        animal.MakeSound();
        animal.Eat();
    }

    

  
    
    //This is an example of polymorphism, where the same method behaves differently based on the object that calls it.
    //The MakeSound method is defined in the base class Animal but is overridden in the derived classes Dog and Cat.    
    
    }
}




//Define a base class Animal with a virtual method MakeSound.
public class Animal : IAnimal
{
    //Implement the Eat method from the IAnimal interface.
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }


    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }

}
//Create two derived classes Dog and Cat that inherit from Animal.
//Override the MakeSound method in each derived class.
public class Dog : Animal 
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof");
    }

}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow");
    }
}




