using System;

namespace TowerDefence
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core("Tower Defence", 1200, 700);
            core.Run();
        }
    }
}
