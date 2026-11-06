int[] scores = { 30, 20, 50, 40, 70 };
int highest = 0;
int total = 0;

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Player {i}: {scores[i]}");

    if (scores[i] > highest)
    {
        highest = scores[i];
    }
    total += scores[i];
}

Console.WriteLine($"Highest score: {highest}");
Console.WriteLine($"Average score: {total / scores.Length}");