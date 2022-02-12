// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Mastermind (Simple Version)");
Random random = new Random();
int[] randomNumber = new int[4];
for (int i = 0; i < randomNumber.Length; i++)
{
    randomNumber[i] = random.Next(1, 7);
}
for (int j = 1; j <= 10; j++)
{
    bool inRange = false;
    int number = 0;
    int numberEntered = 0;
    do
    {
        Console.WriteLine("Attempt {0}: Enter a four digit number:", j);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 0 && number > 999 && number < 10000)
            {
                inRange = true;
                numberEntered = number;
                break;
            }
            else
                Console.WriteLine("Must be a four digit positive value!");
        }
        else
            Console.WriteLine("Enter an Integar Value!");
    }
    while (!inRange);

    string[] display = new string[4];
    for (int i = randomNumber.Length - 1; i >= 0; i--)
    {
        if (number % 10 >= 1 && number % 10 <= 6)
        {
            if (number % 10 == randomNumber[i])
                display[i] = "+";
            else
                display[i] = "-";
        }
        else
            display[i] = " ";
        number = number / 10;
    }
    for (int i = 0; i < display.Length; i++)
    {
        Console.WriteLine(display[i]);
    }
    if (string.Join("", randomNumber) == numberEntered.ToString())
    {
        Console.WriteLine("You Won!");
        break;
    }
    if (j == 10)
        Console.WriteLine("You have lost! Good Luck next time!");
}
