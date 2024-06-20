using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame.Ducks
{
    public abstract class Duck : IDuck
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Duck(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void ShowPosition();
    }

}
