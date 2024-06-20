using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGame.Ducks;

namespace DuckGame.Adapter
{
    // Adapter för att anpassa ForeignDuck till IDuck-gränssnittet
    public class ForeignDuckAdapter : IDuck
    {
        private readonly ForeignDuck _foreignDuck; // Referens till ett ForeignDuck-objekt

        public ForeignDuckAdapter(ForeignDuck foreignDuck)
        {
            _foreignDuck = foreignDuck; // Tar emot ett ForeignDuck-objekt i konstruktorn
        }

        public void ShowPosition()
        {
            _foreignDuck.DisplayPosition(); // Använder ForeignDuck-objektets DisplayPosition-metod för att implementera IDuck-gränssnittet
        }
    }

}
