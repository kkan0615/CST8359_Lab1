IList<string> wordList = new List<string>();

void ImportFile()
{
    try
    {
        // Read the all text in file
        foreach (string line in System.IO.File.ReadLines("./Words.txt"))
        {
            wordList.Add(line);
        }

    }
    catch 
    {
        // Environment.CurrentDirectory

        Console.WriteLine("Could not find file at:" + System.IO.Directory.GetCurrentDirectory() + "\\Words.txt");
        // Console.WriteLine($"Could not find file at: {Directory.GetParent(Environment.CurrentDirectory)?.FullName}Words.txt");
    }
    finally
    {
        Console.WriteLine($"The number of words is {wordList.Count}");
    }
}

IList<string> BubbleSort(IList<string> words)
{
    var watch = new System.Diagnostics.Stopwatch();
    IList<string> result = new List<string>(words);

    watch.Start();
    for (int p = 0; p <= result.Count - 2; p++)
    {
        for (int i = 0; i <= result.Count - 2; i++)
        {
            if (result[i].CompareTo(result[i + 1]) > 0)
            {
                string temp = result[i + 1];
                result[i + 1] = result[i];
                result[i] = temp;
            }
        }
    }
    watch.Stop();
    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    return result;
}

IList<string> LINQOrLambdaSort(IList<string> words)
{
    var watch = new System.Diagnostics.Stopwatch();
    IList<string> result = new List<string>(words);

    watch.Start();
    result = words.OrderBy(str => str).ToList();
    watch.Stop();
    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

    return result;
}

void CountDistinctWords(IList<string> words)
{
    Console.WriteLine($"Distinct count is {words.Distinct().ToList().Count}");
}

void TakeTheFirstSomeWords(int takeNum, IList<string> words)
{
    for (int i = 0; i < takeNum; i++)
    {
        Console.WriteLine(words[i]);
    }
}

void DisplayWordsAndCountStartWithLetter(char letter, IList<string> words)
{
    int count = 0;
    IList<string> filteredWordList = new List<string>();

    for (int i = 0; i < words.Count; i++)
    {
        string word = words[i];
        // Check first letter
        if (word[0] == letter)
        {
            count++;
            filteredWordList.Add(words[i]);
        }
    }

    // Display total count
    Console.WriteLine($"The {count} words that start with '{letter}' are:");
    // Display the word
    for (int i = 0; i < filteredWordList.Count; i++)
    {
        Console.WriteLine(filteredWordList[i]);

    }
}

void DisplayWordsAndCountEndWithLetter(char letter, IList<string> words)
{
    int count = 0;
    IList<string> filteredWordList = new List<string>();

    for (int i = 0; i < words.Count; i++)
    {
        string word = words[i];
        // Check last letter
        if (word[word.Length - 1] == letter)
        {
            count++;
            filteredWordList.Add(words[i]);
        }
    }

    // Display total count
    Console.WriteLine($"The {count} words that end with '{letter}' are:");
    // Display the word
    for (int i = 0; i < filteredWordList.Count; i++)
    {
        Console.WriteLine(filteredWordList[i]);

    }
}

void DisplayWordsAndCountGreaterThanNum(int num, IList<string> words)
{
    int count = 0;
    IList<string> filteredWordList = new List<string>();

    for (int i = 0; i < words.Count; i++)
    {
        string word = words[i];
        if (word.Length > num)
        {
            count++;
            filteredWordList.Add(words[i]);
        }
    }

    // Display total count
    Console.WriteLine($"The {count} words that have more than {num} characters are:");
    // Display the word
    for (int i = 0; i < filteredWordList.Count; i++)
    {
        Console.WriteLine(filteredWordList[i]);

    }
}

void DisplayWordsAndCountLessThanNumStartWithLetter(int num, char letter, IList<string> words)
{
    int count = 0;
    IList<string> filteredWordList = new List<string>();

    for (int i = 0; i < words.Count; i++)
    {
        string word = words[i];
        if (word.Length < num && word[0] == letter)
        {
            count++;
            filteredWordList.Add(words[i]);
        }
    }

    // Display total count
    Console.WriteLine($"The {count} words that have less than {num} characters are:");
    // Display the word
    for (int i = 0; i < filteredWordList.Count; i++)
    {
        Console.WriteLine(filteredWordList[i]);

    }
}

/* Loop untill system exit */
while (true)
{
    /* Menu list */
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
    Console.Write("Select an option: ");

    // Readline keyword
    string keyword = Console.ReadLine() ?? "";

    switch (keyword.ToLower()) {
        case "1":
            {
                ImportFile();
                break;
            }
        case "2":
            {
                BubbleSort(wordList);
                break;
            
            }
        case "3":
            {
                LINQOrLambdaSort(wordList);
                break;
            }
        case "4":
            {
                CountDistinctWords(wordList);
                break;
            }
        case "5":
            {
                TakeTheFirstSomeWords(10, wordList);
                break;
            }
        case "6":
            {
                DisplayWordsAndCountStartWithLetter('j', wordList);
                break;
            }
        case "7":
            {
                DisplayWordsAndCountEndWithLetter('d', wordList);
                break;
            }
        case "8":
            {
                DisplayWordsAndCountGreaterThanNum(4, wordList);
                break;
            }
        case "9":
            {
                DisplayWordsAndCountLessThanNumStartWithLetter(3, 'a', wordList);
                break;
            }
        case "x":
            {
                Environment.Exit(0);
                break;
            }
        default:
            {
                // just break
                break;
            }
    }
}