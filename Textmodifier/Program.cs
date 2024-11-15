
Console.WriteLine("Here we will modify a word of your choice.");
bool gameOn = true;
while (gameOn = true)
{
    Console.WriteLine("Choose one of the following options");
    Console.WriteLine("1. RotateText");
    Console.WriteLine("2. Change word");

    int userAction = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You chose {userAction}. Now type the word you want to modify.");

    string userInput = Console.ReadLine();

    if (userAction == 1)
    {
        Console.WriteLine($"{rotateWord(userInput)}");
    }
    else if (userAction == 2)
    {
        Console.WriteLine($"{changeLetters(userInput)}");
    }
}


string rotateWord(string userInput)
{
        char[] charArray = userInput.ToCharArray();
        Array.Reverse(charArray);
        string newWord = new string(charArray);
    return newWord;
}

string changeLetters(string userInput)
{
    string newWord = "";
    char[] charArray = userInput.ToCharArray();
    foreach (char letter in charArray)
    {
        if (letter == 'e')
        {
            newWord += 'a';
        }
        else
        {
            newWord += letter;
        }
    }
    return newWord;
}