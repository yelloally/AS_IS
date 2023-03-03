using System;

class Animal
{
    public string Species { get; set; }

    //method that prints a message about the animal eating
    public void Eat()
    {
        Console.WriteLine("The " + Species + " is eating.");
    }
}

//class which inherits from Animal
class Dog : Animal
{
    public string Name { get; set; }

    //create method which prints a message about the dog barking
    public void Bark()
    {
        Console.WriteLine("The " + Species + " named " + Name + " is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Species = "Dog";
        dog.Name = "Fido";

        //use the "AS" operator to cast the Dog object to an "Animal" object
        Animal animal = dog as Animal;

        //check if the animal object isnt null
        if (animal != null)
        {
            animal.Eat();
        }

        //use the "IS" operator to check if the animal object is a "Dog" object
        if (animal is Dog)
        {
            Dog newDog = (Dog)animal;
            newDog.Bark();
        }
        Console.ReadLine();
    }
}
