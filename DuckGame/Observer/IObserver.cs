using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame.Observer
{
    // Gränssnitt för observatörer som lyssnar på mina spelstatusförändringar
    public interface IObserver
    {
        void Update(string message);
    }

    public interface IObservable
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify(string message);
    }


}
