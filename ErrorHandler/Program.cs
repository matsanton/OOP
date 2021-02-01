using System;
using System.Collections.Generic;

namespace ErrorHandler
{
    class Program
    {
        static void Main()
        {
            var errorList = new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError()
            };

            foreach (var error in errorList)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
