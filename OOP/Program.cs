// Lexicon NA21 - Övning 3 Inkapsling, arv och polymorfism
using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            ////Test av uppgift 1-4
            //Console.WriteLine("Skapar Nisse Hult");
            //Person person = new Person("Nisse", "Hult");
            //person.Age = 39;
            //Console.WriteLine($"{person.FName} {person.LName} är {person.Age} år gammal.");

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
            //    Console.WriteLine($"Sätter ålder på {person.FName}");
            //    person.Age = 0;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Fel ålder: {ex.Message}");
            //}
            ////------ Slut 1-4 -----

            // 5.
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
            //// ------ Slut 5 ------


            var animals = new List<Animal>()
            {
                new Horse(), new Bird(), new Wolf(), new Dog()
            };

            foreach (var animal in animals)
            {
                //if (animal is IPerson)

                animal.DoSound();
            }

            var dogs = new List<Dog>()
            {
                new Dog(){Name="Fido", Age=5, Breed="Pudel", Weight=15 },
                new Dog(){Name="Lassie", Age=4, Breed="Collie", Weight=20 }
            };

            var aHorse = new Horse();

            //dogs.Add(aHorse);



        }
    }
}
