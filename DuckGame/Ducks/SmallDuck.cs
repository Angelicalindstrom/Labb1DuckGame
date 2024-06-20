using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame.Ducks
{

    // Små ankor
    public class SmallDuck : Duck
    {
        public SmallDuck(int x, int y) : base(x, y) { }

        public override void ShowPosition()
        {
            Console.WriteLine($"Small duck at position ({X}, {Y})");
        }
    }
}
