enum RESULT
{
    DRAW,
    WIN,
    LOSE,
}

class Game
{
    private Player player;
    private Computer computer;

    private int count;

    public Game()
    {
        player = new Player();
        computer = new Computer();
    }

    public void Play()
    {
        bool isPlaying = true;
        PrintWelcome();
        count = 0;
        while (isPlaying)
        {
            string playerChoice = player.ChooseRSP();
            string computerChoice = computer.ChooseRSP();
            int result = Compare(playerChoice, computerChoice);
            player.UpdateScore(result);
            PrintResult(result);
            isPlaying = player.ChooseContinue();
            count++;
            Console.Clear();
        }
        PrintGoodbye();

    }

    private void PrintWelcome()
    {
        Console.WriteLine($"Welcome {player.Name} to Scissors Rock Page ");
    }

    private int Compare(string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice) return (int)RESULT.DRAW;
        if (playerChoice == "Rock" && computerChoice == "Scissors") return (int)RESULT.WIN;
        if (playerChoice == "Paper" && computerChoice == "Rock") return (int)RESULT.WIN;
        return (int)RESULT.LOSE;

    }

    private void PrintResult(int result)
    {
        if (result == (int)RESULT.DRAW) Console.WriteLine("It's a Draw");
        if (result == (int)RESULT.WIN) Console.WriteLine($"{player.Name} Win");
        if (result == (int)RESULT.LOSE) Console.WriteLine($"{player.Name} Lose");
        Console.WriteLine($"Current {player.Name} score: {player.Score}");
    }

    private void PrintGoodbye()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Final {player.Name} score: {player.Score} / {count} Game");
        Console.WriteLine($"Good bye {player.Name}");
        Console.ResetColor();
    }
}