using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame.Ducks
{
    // En klass som representerar en främmande anka som inte implementerar IDuck-gränssnittet
    public class ForeignDuck
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public ForeignDuck(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DisplayPosition()
        {
            Console.WriteLine($"Foreign duck at position ({X}, {Y})");
        }
    }
}
