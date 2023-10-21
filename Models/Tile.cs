using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ProceduralMapGenerationDwarfFortress.Models
{
    public class Tile
    {
        private Vector2 _position;
        private TerrainType _terrainType;

        public Vector2 Position => _position;
        public TerrainType TerrainType => _terrainType;

        public Tile(Vector2 position, TerrainType terrainType)
        {
            _position = position;
            _terrainType = terrainType;
        }
    }
}