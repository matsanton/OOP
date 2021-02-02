// Lexicon NA21 - Övning 3 Inkapsling, arv och polymorfism
using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        private static void Main()
        {
            ////Test av uppgift 3.1) 1-4
            //Person p0= new Person("Nisse", "Hult");
            //p0.Age = 39;
            //Console.WriteLine($"{p0.FName} {p0.LName} är {p0.Age} år gammal.");

            //try
            //{
            //    Console.WriteLine("Skapar p1");
            //    Person p1 = new Person("Bo", "Ek");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Fel vid skapande av Person p1: {ex.Message}");
            //}

            //try
            //{
            //    Console.WriteLine($"Sätter ålder på {p0.FName}");
            //    p0.Age = 0;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Fel ålder: {ex.Message}");
            //}
            ////------ Slut 3.1) 1-4 ------

            // 3.1) 5
            //PersonHandler ph = new PersonHandler();

            //var persons = new List<Person>()
            //{
            //    ph.CreatePerson(56, "Sven", "Gardin", 1.83, 84.5),
            //    ph.CreatePerson(44, "Nisse", "Pärlemo", 1.68, 92.0),
            //    ph.CreatePerson(47, "Astor", "Flanell", 1.75, 78.0),
            //    ph.CreatePerson(32, "Salvador", "Dahlberg", 1.88, 83.0)
            //};

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Personen " +
            //        $"{ph.GetFullName(person)} är {ph.GetAge(person)} år, väger {ph.GetWeight(person)} kg.");
            //}

            //ph.SetWeight(persons[0], 85);
            //ph.SetAge(persons[0], 57);

            //Console.WriteLine($"{ph.GetFullName(persons[0])}s nya vikt och ålder är " +
            //    $"{ph.GetWeight(persons[0])} kg och {ph.GetAge(persons[0])} år.");
            //// ------ Slut 3.1) 5 ------

            // 3.2 Arv
            // Svar på 13. Om alla fåglar behöver ett nytt attribut läggs det i klassen Bird.
            // Svar på 14. Om alla djur behöver ett nytt attribut läggs det i klassen Animal.

            // 3.3 Polymorfism
            var animals = new List<Animal>()
            {
                new Horse("Pålle", "Kallblod", age: 9, weight: 300.0),
                new Bird("Polly", age: 2, weight: 0.2,wingspan: 90),
                new Wolf("Stora stygga vargen", age: 30, weight: 100.0, teethLength: 2.3),
                new Dog("Lufsen", "Blandad", age:6, weight: 40.0),
                new Worm("Max", age: 1, weight: 0.02, isPoisonous: false),
                new Hedgehog("Sonic", numberOfSpikes: 849, age: 10, weight: 5.5 ),
                new Wolfman("Jack", age: 39, weight: 90, teethLength: 2.0, shoeSize: 45),
                new Dog("Lassie", "Collie", age: 6, weight: 20.0)
            };

            Console.WriteLine("*** Djur i listan: ***");
            foreach (var animal in animals)
            {
                Console.Write(animal.ToString()+": ");
                if (animal is IPerson)
                {
                    (animal as IPerson).Talk();
                }
                else
                {
                    animal.DoSound();
                }
            }

            // 8. Lista för hundar
            var dogs = new List<Dog>()
            {
                new Dog("Fido", "Pudel", age: 5, weight: 15.0),
                new Dog("Lassie", "Collie", age: 6, weight: 20.0)
            };

            var aHorse = new Horse("Ina Scott", "Varmblod", 9, 300.0);
            // dogs.Add(aHorse); går ej
            // Svar på 9: listan dogs är en lista av objekt av typen Dog. Det går inte att lägga till ett objekt av typen Horse 
            // för det är en annan typ även om båda ärver från Animal. 
            // Svar på 10: Det måste vara en List<Animal> för att både Dog och Horse ska kunna lagras tillsammans.
            Console.WriteLine("\n*** Animal Stats ***");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            // Svar på 13: Polymorfism regel 1: Vi hanterar alla objekt i animals som instanser av Animal och
            // enligt regel 2 så används den mest specialiserade metoden, t.ex. kommer Stats-metoden i
            // Dog-klassen att användas för instanser av Dog.

            Console.WriteLine("\n*** Enbart hundar ***");
            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    // Svar på 16: Det går inte att komma åt Info() från animals.
                    // Svar på 17: Metoden Info() finns inte i klassen Animal, man måste
                    // casta om animal till en instans av klassen Dog för att komma åt den.
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine((animal as Dog).Info()); // 18.
                }
            }
           
        }
    }
}
