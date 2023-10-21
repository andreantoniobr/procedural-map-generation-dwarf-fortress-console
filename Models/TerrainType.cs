namespace ProceduralMapGenerationDwarfFortress.Models
{
    public class TerrainType
    {
        private string _terrainName;
        private float _minNoiseHight;
        private string _terrainChar;

        private ConsoleColor _color;

        public string TerrainName => _terrainName;
        public float MinNoiseHight => _minNoiseHight;
        
        public string TerrainChar => _terrainChar;

        public ConsoleColor Color => _color;

        public TerrainType(string terrainName, float minNoiseHight, string terrainChar, ConsoleColor color)
        {
            _terrainName = terrainName;
            _minNoiseHight = minNoiseHight;
            _terrainChar = terrainChar;
            _color = color;
        }
    }
}