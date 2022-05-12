IList<string> words = new List<string>();

void ImportFile()
{
    // Read the all text in file
    foreach (string line in System.IO.File.ReadLines("./Words.txt"))
    {
        words.Add(line);
        // Console.WriteLine(line);
    }
}

IList<string> BubbleSort(IList<string> words)
{
    IList<string> result = new List<string>();
    for (int p = 0; p <= words.Count - 2; p++)
    {
        for (int i = 0; i <= words.Count - 2; i++)
        {
            if (words[i].CompareTo(words[i + 1]) > 0)
            {
                string temp = words[i + 1];
                words[i + 1] = words[i];
                words[i] = temp;
            }
        }
    }
    return result;
}

IList<string> LINQOrLambdaSort(IList<string> words)
{
    IList<string> result = new List<string>();
    for (int p = 0; p <= words.Count - 2; p++)
    {
        for (int i = 0; i <= words.Count - 2; i++)
        {
            if (words[i].CompareTo(words[i + 1]) > 0)
            {
                string temp = words[i + 1];
                words[i + 1] = words[i];
                words[i] = temp;
            }
        }
    }
    return result;
}

void CountDistinctWords(IList<string> words)
{
    Console.WriteLine(words.Distinct().ToList().Count);
}

void TakeTheFirstSomeWords(int takeNum, IList<string> words)
{
    for (int i = 0; i < takeNum; i++)
    {
        Console.WriteLine(words[i]);
    }
}

void DisplayWordsAndCountStartWithLetter(char startLetter, IList<string> words)
{
    int count = 0;
    IList<string> filteredWordList = new List<string>();
    for (int i = 0; i < words.Count; i++)
    {
        if (words[i][0] == startLetter)
        {
            count++;
            filteredWordList.Add(words[i]);
        }
    }

    // Display total count
    Console.WriteLine($"The {count} words that start with 'j' are:");

    for (int i = 0; i < filteredWordList.Count; i++)
    {
        Console.WriteLine(filteredWordList[i]);

    }
}

while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - Import Words from File");
    Console.WriteLine("2 - Bubble Sort words");
    Console.WriteLine("3 - LINQ / Lambda sort words");
    Console.WriteLine("4 - Count the Distinct Words");
    Console.WriteLine("5 - Take the first 10 words");
    Console.WriteLine("6 - Get and display words that start with 'j' and display the count");
    Console.WriteLine("7 - Get and display words that end with 'd' and display the count");
    Console.WriteLine("8 - Get and display words that are greater than 4 characters long, and display the count");
    Console.WriteLine("9 - Get and display words that are less than 3 characters long and start with the letter 'a', and display the count");
    Console.WriteLine("x – Exit");
    Console.WriteLine("\n");
    Console.WriteLine("Select an option:");

    // Readline number
    string? keyword = Console.ReadLine().ToLower();

    switch (keyword) {
        case "1":
            {
                ImportFile();
                break;
            }
        case "2":
            {
                BubbleSort(words);
                break;
            
            }
        case "3":
            {
                LINQOrLambdaSort(words);
                break;
            }
        case "4":
            {
                CountDistinctWords(words);
                break;
            }
        case "5":
            {
                TakeTheFirstSomeWords(10, words);
                break;
            }
        case "6":
            {
                DisplayWordsAndCountStartWithLetter('j', words);
                break;
            }
        case "x":
            {
                Environment.Exit(0);
                break;
            }
        default:
            {
                // just break the line Lab1.exe
                break;
            }
    }
}