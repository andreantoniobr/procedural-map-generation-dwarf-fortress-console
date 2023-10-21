# Procedural Map Generation Dwarf Fortress Console

Implementation of Simplex Noise for procedural terrain generation in the console.

### How Works

This implementation uses the simplex noise library to generate values in the Range 0f to 255f. These values are used as a basis for establishing the height of the terrain. And then each Tile represented by a Char in a Color is printed in the Console.

### Example of implementation

    //Standard values
    int mapWidth = 100;
    int mapHeight = 50;
    int seed = 10;
    float scale = 0.05f;
    
    //SimplexNoise - Range 0f to 255f
    float minNoiseHightWater = 0f;
    float minNoiseHightSand = 50f;
    float minNoiseHightGrass = 80f;
    float minNoiseHightMountain = 220f;
    
    TerrainType water = new TerrainType("Water", minNoiseHightWater, "s", ConsoleColor.DarkBlue);
    TerrainType sand = new TerrainType("Sand", minNoiseHightSand, "#", ConsoleColor.DarkYellow);
    TerrainType grass = new TerrainType("Grass", minNoiseHightGrass, "#", ConsoleColor.DarkGreen);
    TerrainType mountain = new TerrainType("Mountain", minNoiseHightMountain, "m", ConsoleColor.DarkGray);

    //Create Map Terrains
    TerrainType[] terrains = new TerrainType[] 
    { 
        water, 
        sand, 
        grass, 
        mountain
    };
    
    MapGenerator.GenerateMap(mapWidth, mapHeight, seed, scale, terrains);

### Simplex Noise

https://github.com/WardBenjamin/SimplexNoise
