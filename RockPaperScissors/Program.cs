//Console.ForegroundColor = ConsoleColor.Blue;
//Console.BackgroundColor = ConsoleColor.Green;
//Console.Clear();
//Console.ResetColor();

const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

Console.ForegroundColor = ConsoleColor.Blue;
for ( int i = 1; i <= 3; i++ )
{
    Console.Beep();
}
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Play Rock, Paper, Scissors!");
Console.ResetColor();


Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");

string playerMove = Console.ReadLine();
Console.Beep();
Console.ResetColor();

if (playerMove == "r" || playerMove == "rock" || playerMove == "R" || playerMove == "Rock")
{
    playerMove = rock;
}
else if (playerMove == "p" || playerMove == "paper" || playerMove == "P" || playerMove == "Paper")
{
    playerMove = paper;
}
else if (playerMove == "s" || playerMove == "scissors" || playerMove == "S" || playerMove == "Scissors")
{
    playerMove = scissors;
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Invalid Input! Try Again...");
    Console.ResetColor();
    Console.Beep();
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next( 1, 4 );

string computerMove = string.Empty;

switch (computerRandomNumber)
{
    case 1: 
        computerMove = rock; 
        break;
    case 2:
        computerMove = paper;
        break;
    case 3:
        computerMove = scissors;
        break;
}
Console.WriteLine($"The computer chose {computerMove}.");

if ((playerMove == "Rock" && computerMove == "Scissors") ||
    (playerMove == "Paper" && computerMove == "Rock") ||
    (playerMove == "Scissors" && computerMove == "Paper"))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You Win!"); 
    Console.ResetColor();
}
else if ((playerMove == "Rock" && computerMove == "Paper") ||
         (playerMove == "Paper" && computerMove == "Scissors") ||
         (playerMove == "Scissors" && computerMove == "Rock"))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You Lose!");
    Console.ResetColor();
}
else if ((playerMove == "Rock" && computerMove == "Rock") ||
         (playerMove == "Paper" && computerMove == "Paper") ||
         (playerMove == "Scissors" && computerMove == "Scissors"))
{ Console.WriteLine("Draw!"); }

