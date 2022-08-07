using System;

namespace Lab_1
{
    class lab1
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("What is your name?");

            name = Console.ReadLine();

            Console.Write("Hello " + name + "\n");

            Console.Write("Thank you for run my first lab! Press any key to end the application");

            Console.Read();
        }

    }
}
// question 1: It gives an error saying that semicolon is expected.
// In c# semicolon is a statement terminator therefore its needed at the end of each statement.

// question 2 : It gives an error describes as unable to convert string to int. The reason is that
// name's value is a string but by writing int we decribe the value of name as an int to the programme.


// question 3: it give the error "System.FormatException: 'Input string was not in a correct format.'" but
// the error is given after running the program and asking your name. The error happend because of the fact
// that program expects an int as input so when we enter an int like 16 it runs without error.:
// What is your name?16
// Hello16
// Thank you for run my first lab! Press any key to end the application.

// question 4: compiling error is the kind of error that happens befor running the program like typos in
// the statments or semicolons like question 1 nad 2 while runtime errors are like the question 3 which happens after you run the program.