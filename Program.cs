// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> Plays = new List<string> {
    "Rock",
    "Paper",
    "Scissors"
};

// int score = 0;

bool playing = true;


do
{


    Random rand = new Random();
    int randomIndex = rand.Next(0, Plays.Count - 0);
    string secretPlay = Plays[randomIndex];
    bool won = false;

    bool validInput = false;
    string? input = "";
    do
    {
        input = Console.ReadLine();
        if (input == "Rock" || input == "Paper" || input == "Scissors")
        {
            validInput = true;
        }
    } while (validInput == false);

    if (input != null)
    {

        if (input == secretPlay)
        {
            Console.WriteLine(secretPlay);
            Console.WriteLine("Tied");
        }
        if (input == "Rock" && secretPlay == "Scissors")
        {
            Console.WriteLine(secretPlay);
            won = true;
        }
        else if (input == "Rock" && secretPlay == "Paper")
        {
            Console.WriteLine(secretPlay);
            won = false;
            // Console.WriteLine("You Lost Loser");
        }
        else if (input == "Scissors" && secretPlay == "Rock")
        {
            Console.WriteLine(secretPlay);
            won = false;
            //  Console.WriteLine("You Lost Loser");
        }
        else if (input == "Scissors" && secretPlay == "Paper")
        {
            Console.WriteLine(secretPlay);
            won = true;
            //  Console.WriteLine("You Won!");
        }
        else if (input == "Paper" && secretPlay == "Scissors")
        {
            Console.WriteLine(secretPlay);
            won = false;
            //  Console.WriteLine("You Lost Loser");
        }
        else if (input == "Paper" && secretPlay == "Rock")
        {
            Console.WriteLine(secretPlay);
            won = true;
            //  Console.WriteLine("You Won!");
        }
    }
    if (won)
    {
        Console.WriteLine("You Won!");
    }
    else { Console.WriteLine("You Lost Loser"); }
} while (playing);


// string keepPlaying = Console.ReadLine();
// if(keepPlaying == "rock"){
//     playing = false;
// };








