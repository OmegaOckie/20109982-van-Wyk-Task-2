using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    abstract class Tile
    {
        //Q.2.1 Defining the Variables
        protected int x { get; set; }
        protected int y { get; set; }

        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON
        }

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
