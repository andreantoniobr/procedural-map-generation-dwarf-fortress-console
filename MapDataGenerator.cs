using SimplexNoise;
namespace ProceduralMapGenerationDwarfFortress
{
    public static class MapDataGenerator
    {
        public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, int seed, float scale) 
        {           
            Noise.Seed = seed; 
            float[,] noiseMap = Noise.Calc2D(mapWidth, mapHeight, scale);
            return noiseMap;
        }
    }
}