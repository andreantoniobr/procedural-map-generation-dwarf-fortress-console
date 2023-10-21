using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProceduralMapGenerationDwarfFortress.Models;

namespace ProceduralMapGenerationDwarfFortress
{
    public class MapDrawer
    {
        public static void Draw(Tile[,] tileMapData, int mapWidth, int mapHeight)
        {            
            if (tileMapData != null && mapWidth > 0 && mapHeight > 0)
            {                
                for (int y = 0; y < mapHeight; y++)
                {
                    Console.WriteLine();
                    for (int x = 0; x < mapWidth; x++)
                    {
                        if (tileMapData[x, y] != null)
                        {
                            DrawTile(tileMapData[x, y].TerrainType);  
                        }                                             
                    }
                }
                Console.ReadKey();
            }
        }
        
        public static void DrawTile(TerrainType terrainType)
        {
            if (terrainType != null)
            {
                Console.ForegroundColor = terrainType.Color;
                Console.Write(terrainType.TerrainChar);
            }
        }
    }
}