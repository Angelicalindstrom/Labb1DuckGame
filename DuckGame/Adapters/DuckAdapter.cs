using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGame.Ducks;

namespace DuckGame.Adapter
{
    // Adapter för att anpassa Duck-objekt till IDuck-gränssnittet
    public class DuckAdapter : IDuck
    {
        private readonly Duck _duck; // Referens till ett Duck-objekt

        public DuckAdapter(Duck duck)
        {
            _duck = duck; // Tar emot ett Duck-objekt i konstruktorn
        }

        public void ShowPosition()
        {
            _duck.ShowPosition(); // Använder Duck-objektets ShowPosition-metod för att implementera IDuck-gränssnittet
        }
    }

}
