using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGame.Ducks;

namespace DuckGame.Factory
{
    // Abstrakt fabriksklass för att skapa olika typer av ankor
    public abstract class DuckFactory
    {
        public abstract Duck CreateDuck(int x, int y); // Metod för att skapa en anka med angivna koordinater
    }

    // Fabrik för att skapa små ankor
    public class SmallDuckFactory : DuckFactory
    {
        public override Duck CreateDuck(int x, int y)
        {
            return new SmallDuck(x, y); // Returnerar en instans av SmallDuck
        }
    }

    // Fabrik för att skapa stora ankor
    public class BigDuckFactory : DuckFactory
    {
        public override Duck CreateDuck(int x, int y)
        {
            return new BigDuck(x, y); // Returnerar en instans av BigDuck
        }
    }
}
