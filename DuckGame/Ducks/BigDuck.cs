using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame.Ducks
{
    //Stora ankor
    public class BigDuck : Duck
    {
        public BigDuck(int x, int y) : base(x, y) { }

        public override void ShowPosition()
        {
            Console.WriteLine($"Big duck at position ({X}, {Y})");
        }
    }
}
