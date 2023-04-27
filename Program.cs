System.Console.WriteLine(Level3ArraySplit());
// string Level2BubbleSort()
// {
//     var rand = new Random(4711);
//     var number = new int[75000];

//     for (int i = 0; i < 75000; i++)
//     {
//         var randomNumber = rand.Next(1, 1000000001);
//         number[i] = randomNumber;
//     }

//     for (int i = 0; i < number.Length - 1; i++)
//     {
//         for (int j = 0; j < number.Length - i - 1; j++)
//         {
//             if (number[j] > number[j + 1])
//             {
//                 int tmp = number[j];
//                 number[j] = number[j + 1];
//                 number[j + 1] = tmp;
//             }
//         }
//     }

//     var sum = 0;
//     for (int i = 0; i < number.Length - 1; i++)
//     {
//         sum += Math.Abs(number[i] - number[i + 1]);
//     }

//     var averageDistance = (double)sum / (number.Length - 1);
//     return $"averageDistance distance: {averageDistance:f4}";
// }

string Level3ArraySplit()
{
    var rand = new Random(4711);
    var number = new int[1000000];

    for (int i = 0; i < 1000000; i++)
    {
        var randomNumber = rand.Next(1, 1000000001);
        number[i] = randomNumber;
    }

    Array.Sort(number);
    var sum = 0;
    for (int i = 0; i < number.Length - 1; i++)
    {
        sum += Math.Abs(number[i] - number[i + 1]);
    }

    var averageDistance = (double)sum / (number.Length - 1);
    return $"averageDistance distance: {averageDistance:f5}";
}