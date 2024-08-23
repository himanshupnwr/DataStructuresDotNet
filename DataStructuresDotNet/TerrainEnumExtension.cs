namespace DataStructuresDotNet
{
    internal static class TerrainEnumExtension
    {
        public static ConsoleColor GetColor(this TerrainEnum terrainEnum)
        {
            switch (terrainEnum)
            {
                case TerrainEnum.GRASS: return ConsoleColor.Green;
                case TerrainEnum.SAND: return ConsoleColor.Yellow;
                case TerrainEnum.WATER: return ConsoleColor.Blue;
                default: return ConsoleColor.DarkGray;
            };
        }
        public static char GetChar(this TerrainEnum terrainEnum)
        {
            switch (terrainEnum)
            {
                case TerrainEnum.GRASS: return '\u201c';
                case TerrainEnum.SAND: return '\u25cb';
                case TerrainEnum.WATER: return '\u2248';
                default: return '\u25cf';
            }
        }
    }
}
