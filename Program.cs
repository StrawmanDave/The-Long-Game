//David 10/26/24 The Long Game

//Clears the screen for better viewing
Console.Clear();
int score = 0;

Console.Write($"Please enter your name ");
string username = Console.ReadLine();

//Now how to check if the users file already exists access it and keep adding scores
if(File.Exists($"{username}.txt"))
{
    if(username == Path.GetFileNameWithoutExtension($"/home/david/david-programming-1400/The-Long-Game/{username}"))
    {
       string oldScore = File.ReadAllText($"{username}.txt");
       score = Convert.ToInt32(oldScore);
    }
}
// Now how to make a score and add 1 to it for every keypressed
Console.Write("Start masshing buttons on the keyboard!");
while(true)
{

    if(Console.ReadKey().Key == ConsoleKey.Enter)
    {
        break;
    }else
    {
        score = score + 1;
    }
    Console.WriteLine();
    Console.Write($"You current score is now {score}. Now press any key to gain points. ");
    
};

string saveScore = $"{Convert.ToString(score)}";


// How to save score the file username?
File.WriteAllText($"{username}.txt", saveScore);
