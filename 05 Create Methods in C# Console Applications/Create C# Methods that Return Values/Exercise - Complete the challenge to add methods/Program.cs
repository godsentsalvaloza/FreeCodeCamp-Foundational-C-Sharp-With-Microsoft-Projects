Random random = new Random();
string? userInput;
Console.WriteLine("Would you like to play? (Y/N)");

bool ShouldPlay()
{
    userInput = Console.ReadLine();

    if (userInput != null)
        userInput.ToLower();

    if (userInput == "y")
        return true;
    return false;

}

if (ShouldPlay())
{
    PlayGame();
}

string WinOrLose(int target, int roll)
{
    if (target < roll)
        return "You win!";

    return "You lose!";
}

int Target()
{
    return random.Next(1, 6);
}

int Roll() {
    return random.Next(1, 7);
}


void PlayGame()
{
    bool play = true;

    while (play)
    {

        int target = Target();
        int roll = Roll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target: target, roll: roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}