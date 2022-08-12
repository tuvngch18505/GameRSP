
class Player
{

    enum RESULT
    {
        DRAW,
        WIN,
        LOSE,
    }
    private string name;
    private int score;
    public string Name
    {
        get { return name; }
        set
        {
            if (name != null)
            {
                name = value;
            }
            else
            {
                name = "Player 1";
            }
        }
    }

    public int Score
    {
        get { return score; }

    }

    public Player()
    {
        Console.Write("Enter player name: ");
        Name = Console.ReadLine();
    }

    public void UpdateScore(int result)
    {
        if (result == (int)RESULT.WIN) score++;
        else if (result == (int)RESULT.LOSE) score--;
    }

    public string ChooseRSP()
    {
        bool isInvalid = true;
        string playerChoice = "";
        while (isInvalid)
        {
            Console.WriteLine("Please choose one of the following: Scissors, Rock, Paper");
            playerChoice = Console.ReadLine();
            isInvalid = playerChoice != "Scissors" && playerChoice != "Rock" && playerChoice != "Paper";
            if (isInvalid) Console.WriteLine("Invalid choice. Please try again");
        }
        return playerChoice;
    }

    public bool ChooseContinue()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Do you want to play againt (y/n) ");
        string answer = Console.ReadLine();
        Console.ResetColor();
        return answer == "y";
        
    }
}