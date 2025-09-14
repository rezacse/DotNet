using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding.ThreadTest
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks: Woof woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows: Meow!");
        }
    }

    interface IChargeable
    {
        void Charge();
    }

    class Smartphone : IChargeable
    {
        public void Charge()
        {
            Console.WriteLine("Charging the smartphone.");
        }
    }

    class Laptop : IChargeable
    {
        public void Charge()
        {
            Console.WriteLine("Charging the laptop.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IChargeable phone = new Smartphone();
            IChargeable laptop = new Laptop();

            phone.Charge();  // Calls Smartphone's Charge
            laptop.Charge(); // Calls Laptop's Charge
        }
    }


    internal class PolymorphismHelper
    {
        public PolymorphismHelper()
        {
            Animal animal = new Animal();
            animal.MakeSound();

            Animal dog = new Dog();
            dog.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();


            IChargeable smartphone = new Smartphone();
            smartphone.Charge();

            IChargeable laptop = new Laptop();
            laptop.Charge();
        }
    }
}
