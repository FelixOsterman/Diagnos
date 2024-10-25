int guesses = 0;

Console.WriteLine("Guess the word!");
Console.WriteLine("Chose between 1-5 guesses.");
Console.WriteLine("Write the number you want.");

string number = Console.ReadLine();

if (number == "one")
{
    guesses += 4;
}
if (number == "two")
{
    guesses += 3;  
}
if (number == "three")
{
    guesses += 2;
}
if (number == "four")
{
    guesses += 1;
}
if (number == "five")
{
    guesses += 0;
}
else
{
    Console.WriteLine("Your number you wrote is not gilty or there was a spelling mistake.");
}

while (guesses > 5)
{
    string guess = Console.ReadLine();

    if (guess == "left")
    {
        Console.WriteLine("Right answer");
        guesses += 5;
    }
    else 
    {
        Console.WriteLine("Wrong answer");
        guesses += 1;
    }
}

Console.WriteLine("Press any button to close.");
Console.ReadKey();
