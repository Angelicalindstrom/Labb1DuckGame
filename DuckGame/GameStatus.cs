using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGame.Observer;

namespace DuckGame
{
    // Ansvarar för att hantera spelstatus och meddela förändringar till registrerade observatörer
    public class GameStatus : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>(); // Lista med registrerade observatörer

        public void Register(IObserver observer)
        {
            _observers.Add(observer); // Lägger till en observatör i listan
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer); // Tar bort en observatör från listan
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message); // Skickar meddelandet till varje observatör
            }
        }
    }

}
