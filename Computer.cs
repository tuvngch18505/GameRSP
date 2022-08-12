class Computer{
    public string ChooseRSP()
    {
        string[] choices = {"Scissors","Rock","Paper"};
        Random random = new Random();
        int index = random.Next(0, choices.Length);
        Console.WriteLine($"Computer Choose:  {choices[index]}");
        return choices[index];
    }
}