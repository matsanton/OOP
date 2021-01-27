// Lexicon NA21 - Övning 3 Inkapsling, arv och polymorfism
using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skapar Nisse Hult");
            Person person = new Person("Nisse", "Hult");
            person.Age = 39;
            Console.WriteLine($"{person.FName} {person.LName} är {person.Age} år gammal.");

            try
            {
                Console.WriteLine("Skapar p1");
                Person p1 = new Person("Bo", "Ek");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fel vid skapande av Person p1: {ex.Message}");
            }

            try
            {
                Console.WriteLine($"Sätter ålder på {person.FName}");
                person.Age = 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fel ålder: {ex.Message}");
            }
        }
    }
}
