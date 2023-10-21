using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using ProceduralMapGenerationDwarfFortress.Models;

namespace ProceduralMapGenerationDwarfFortress
{
    public class TileMapDataGenerator
    {
        public static bool TryGetTileMapData(float [,] mapData, TerrainType[] terrains, int mapWidth, int mapHeight, out Tile[,] tileMapData)
        {
            tileMapData = new Tile[mapWidth, mapHeight];
            bool canGetTileMapData = false;
            if (mapData != null && terrains != null && mapWidth > 0 && mapHeight > 0)
            {
                canGetTileMapData = true;
                for (int x = 0; x < mapWidth; x++)
                {
                    for (int y = 0; y < mapHeight; y++)
                    {
                        Vector2 position = new Vector2(x, y);
                        float noiseHeight = mapData[x, y];
                        if (TryGetTerrainType(terrains, noiseHeight, out TerrainType terrainType))
                        {
                            tileMapData[x, y] = new Tile(position, terrainType);
                        }
                    }
                }
            }            
            return canGetTileMapData;
        }  

        private static bool TryGetTerrainType(TerrainType[] terrains, float noiseHeight, out TerrainType terrainType)
        {
            terrainType = null;
            bool canGetTerrainType = false;
            if (terrains.Length > 0)
            {
                for (int i = 0; i < terrains.Length; i++)
                {
                    if (noiseHeight >= terrains[i].MinNoiseHight)
                    {
                        canGetTerrainType = true;
                        terrainType = terrains[i];
                    }
                }
            }
            return canGetTerrainType;
        }     
    }
}