using System;
using System.Collections.Generic;
using System.Text;

namespace UnityStudy
{
    class Class_Interface
    {
        public interface IMovable
        {
           void Move();
        }

        class Animal
        {
            string name = string.Empty;
            int age = 0;

            public void SpeakFunc()
            {
                Speak();
            }

            protected virtual void Speak()
            {
                Console.WriteLine("I don't know what you say");
            }
        }

        class Dog : Animal, IMovable
        {
           public void Move()
            {
                Console.WriteLine("Running Fast!");
            }
            protected override void Speak()
            {
                Console.WriteLine("Woof");
            }
        }

        class Cat : Animal
        {
            protected override void Speak()
            {
                Console.WriteLine("Meow");
            }
        }

        private static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SpeakFunc();
            Cat cat = new Cat();
            cat.SpeakFunc();
            dog.Move();
        }
    }
}
