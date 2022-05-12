IList<string> words = new List<string>();

void importFile()
{
    // Read the all text in file
    string text = System.IO.File.ReadAllText("./Words.txt");
    Console.WriteLine(text);
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
    string keyword = Console.ReadLine();

    switch (keyword) {
        case "1":
            {
                importFile();
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