using System;
using System.Collections.Generic;

namespace ErrorHandler
{
    public class Program
    {
        private static void Main()
        {
            var errorList = new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
                new EmptyInputError(),
                new DateInputError(),
                new ZipcodeInputError()
            };

            foreach (var error in errorList)
            {
                Console.WriteLine(error.UEMessage());
            }

            // 3.4 Polymorfism
            // Svar på 11: Man kan behandla grupper av klasser på ett likartat sätt.
            // Svar på 12: Man kan enkelt lägga till nya klasser (t.ex i det här fallet klasser som ärver från UserError) utan att
            //             ändra i gammal kod och utnyttja gemensam kod i basklassen.
            // Svar på 13: Abstrakta klasser kan innehålla implementation av metoder. Interface kan inte ha någon implementation
            //             bara deklarationer av properties eller metoder. En klass kan implementera flera interface men bara ärva
            //             från en basklass. Metoder, properies mm kan ha access-modifierare i en abstrakt klass men metoder och 
            //             properties är automatiskt public i ett interface.
        }
    }
}
