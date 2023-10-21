using ProceduralMapGenerationDwarfFortress.Models;

namespace ProceduralMapGenerationDwarfFortress
{
    public class MapGenerator
    {
        public static void GenerateMap(int mapWidth, int mapHeight, int seed, float scale, TerrainType[] terrains) 
        {
            float[,] mapData = MapDataGenerator.GenerateNoiseMap(mapWidth, mapHeight, seed, scale);
            if (TileMapDataGenerator.TryGetTileMapData(mapData, terrains, mapWidth, mapHeight, out Tile[,] tileMapData))
            {
                MapDrawer.Draw(tileMapData, mapWidth, mapHeight);    
            }
        }
    }
}