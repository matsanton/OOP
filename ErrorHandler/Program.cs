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
        }
    }
}
