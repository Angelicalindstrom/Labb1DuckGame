using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGame.Observer;

namespace DuckGame
{
    // Klass som representerar spelare som lyssnar på spelstatusförändringar
    public class Player : IObserver
    {
        public string Name { get; } // Spelarens namn

        public Player(string name)
        {
            Name = name; // Tar emot spelarens namn i konstruktorn
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received message: {message}"); // Metod som implementerar IObserver-gränssnittet och reagerar på meddelanden
        }
    }

}
