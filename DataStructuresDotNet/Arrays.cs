using System.Globalization;
using System.Text;

namespace DataStructuresDotNet
{
    internal class Arrays
    {
        static void MainArray(string[] args)
        {
            //display all the months of the year
            string[] months = new string[12];
            for(int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[month-1] = name;
            }

            foreach (var item in months)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //multi-dimensional array
            //example of multiplication table
            int[,] results = new int[10, 10];
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < results.GetLength(1); j++)
                {
                    results[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0,4}", results[i, j]);
                }
            }
            Console.ReadLine();

            //Map of a game example
            //Map is reactangle with 11 rows and 10 columns
            //Element specifies type of terrain - grass, sand, water, or wall
            //Place on map shown in a particular color - like green for grass
            //Custom character depicts terrain type - "~" for water
            TerrainEnum[,] map =
            {
                { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS },
                { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS },
                { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.GRASS, TerrainEnum.GRASS },
                { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WALL },
                { TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL, TerrainEnum.WALL }
            };

            Console.OutputEncoding = UTF8Encoding.UTF8;
            for(int i = 0; i < map.GetLength(0); i++) 
            {
                for (global::System.Int32 j = 0; j < map.GetLength(1); j++)
                {
                    Console.ForegroundColor = map[i, j].GetColor();
                    Console.Write(map[i, j].GetChar() + " ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor= ConsoleColor.Gray;
            Console.ReadLine();

            //jagged array
            //single dimensional array, where each element is another array
            //inner array comprises of different lenghts
            int[][] numbers = new int[4][];
            numbers[0] = new int[] { 9, 5, -9 };
            numbers[1] = new int[] { 0, 3, 12, 51, -3 };
            numbers[3] = new int[] { 54 };

            //jagged array example using a transportation example
            //develop a program that creates a plan of transportation for a year
            //application draws one of the available means of transport
            //program presents the generated plan
            Random random = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TerrainEnum)).Length;
            TransportEnum[][] transport = new TransportEnum[12][];

            for(int month  = 1; month < 12; month++)
            {
                int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month);
                transport[month - 1] = new TransportEnum[daysCount];
                for(int day = 1; day < daysCount; day++)
                {
                    int randomType = random.Next(transportTypesCount);
                    transport[month - 1][day - 1] = (TransportEnum)randomType;

                }
            }

            string[] monthNames = months;
            int monthNamesPart = monthNames.Max(n => n.Length) + 2;
            for (int month = 1; month < transport.Length; month++)
            {
                Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesPart));
                for (int day = 1; day <= transport[month-1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = transport[month - 1][day - 1].GetColor();
                    Console.Write(transport[month - 1][day-1].GetChar());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }
    }

    public enum TerrainEnum
    {
        GRASS,
        SAND,
        WATER,
        WALL
    }

    public enum TransportEnum
    {
        CAR,
        BUS,
        SUBWAY,
        BIKE,
        WALK
    }
}
