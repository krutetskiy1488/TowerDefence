using SFML.Graphics;

namespace TowerDefence
{
    class Content
    {
        public const string RESOURCES_DIR = "..\\..\\..\\Resources\\";

        public static Texture texTile0;
        
        public static void Load()
        {
            texTile0 = new Texture(RESOURCES_DIR + "Textures\\Tiles_0.png");
        }
    }
}
