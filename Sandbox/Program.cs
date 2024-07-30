Console.WriteLine("Type something, then hit enter: ");
string UserInput = Console.ReadLine();
Console.WriteLine($"You wrote: {UserInput}");

Console.WriteLine("Type a number, then hit enter: ");
string NumberInput = Console.ReadLine();
// TryParse takes 2 parameters: the item to be parsed and a variable
// you would like to output (out) to if it is successful
if(Int32.TryParse(NumberInput, out int output))
{
    // Notice how we used j instead of NumberInput
    Console.WriteLine($"The integer was {output}");
    Console.WriteLine(10 + output);
}
else
{
    Console.WriteLine("That was not a number");
}

