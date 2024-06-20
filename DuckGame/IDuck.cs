using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DuckGame
{
    // Gränssnitt för alla typer av ankor
    public interface IDuck
    {
        void ShowPosition(); // Metod för att visa anks position
    }

}
