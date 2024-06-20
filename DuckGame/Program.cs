using System;
using System.Collections.Generic;
using DuckGame.Adapter;
using DuckGame.Ducks;
using DuckGame.Factory;

namespace DuckGame
{
    // Angelica Lindström .NET23
    // Factory method, Adapter och Observer
    // Factory Method används för att skapa olika typer av ankor. Detta möjliggör att nya anktyper kan läggas till utan att ändra den kod som använder dessa fabriker.
    // Adapter används för att anpassa Duck-objekt till IDuck-gränssnittet. Detta möjliggör att olika typer av ankor kan hanteras enhetligt.
    // Observer används för att notifiera spelare om förändringar i spelet, såsom när en anka elimineras.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar fabriker för små och stora ankor
            DuckFactory smallDuckFactory = new SmallDuckFactory();
            DuckFactory bigDuckFactory = new BigDuckFactory();

            // Skapar en lista för att hålla ankor
            List<IDuck> ducks = new List<IDuck>
            {
                // Använder fabrikerna för att skapa ankor och lägga till dem i listan
                new DuckAdapter(smallDuckFactory.CreateDuck(2, 3)),
                new DuckAdapter(bigDuckFactory.CreateDuck(5, 8)),
                new ForeignDuckAdapter(new ForeignDuck(7, 4)) // Använder en adapter för att inkludera en främmande anka
            };

            // Skapar en instans av spelstatus, hantera observer-mönstret
            GameStatus status = new GameStatus();

            // Skapar spelare och registrerar dem som observatörer i GameStatus
            Player player1 = new Player("Pontus");
            Player player2 = new Player("Benji");
            status.Register(player1);
            status.Register(player2);

            // Loopar genom listan med alla ankor, visar positioner
            foreach (IDuck duck in ducks)
            {
                duck.ShowPosition();
            }

            // Meddelar alla registrerade observatörer om att en anka har eliminerats
            status.Notify("One Duck has been eliminated!");
        }
    }
}
