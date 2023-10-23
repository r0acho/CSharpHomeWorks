int count = 0;
string stop = "stop";
while (true)
{
    string userAnswer = Console.ReadLine()!;
    if (userAnswer.ToLower() == stop)
    {
        break;
    }

    int number = Convert.ToInt32(userAnswer);
    if (number > 0)
    {
        count++;
    }
    Console.WriteLine(count);
}