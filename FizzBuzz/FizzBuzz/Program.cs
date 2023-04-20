// See https://aka.ms/new-console-template for more information
string input = "";
do
{
    Console.WriteLine("enter number 1 to 100");
    input = Console.ReadLine();
    int x = int.Parse(input);
    Console.WriteLine(((x % 3 == 0) && (x % 5 == 0)) ? "FizzBuzz" : (x % 3 == 0) ? "Fizz" : (x % 5 == 0) ? "Buzz" : x.ToString());
} while (input != "x");
