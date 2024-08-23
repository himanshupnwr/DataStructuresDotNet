namespace DataStructuresDotNet
{
    internal class SortedDictionary
    {
        public void SortDictExample()
        {
            SortedDictionary<string, string> definitions = new SortedDictionary<string, string>();
            do
            {
                Console.Write("Choose an option ([a] - add, [1] - list):");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();
                if(keyInfo.Key == ConsoleKey.A)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter the name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the explanation");
                    string explanation = Console.ReadLine();
                    definitions[name] = explanation;
                    Console.ForegroundColor= ConsoleColor.Gray;
                }
                else if(keyInfo.Key == ConsoleKey.L)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach(KeyValuePair<string, string> pair in definitions)
                    {
                        Console.Write($"{pair.Key} - {pair.Value}");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Exit the Program?");
                    if(Console.ReadKey().Key == ConsoleKey.Y) {
                        break;
                    }
                }
            }
            while (true);
        }
    }
}
