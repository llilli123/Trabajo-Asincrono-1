using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trabajo_Asincrono_1
{
    internal class Produccion
    {
        public string Nombre { get; }
        public int TotalDeItems { get; }
        public int Producido { get; private set; }

        private readonly Random _rnd = new();

        public Produccion(string nombre, int totalDeItems)
        {
            Nombre = nombre;
            TotalDeItems = totalDeItems;
        }

        public async Task RunAsync(IProgress<int> progressItems,Action<string> log, CancellationToken ct)
        {
            log($"{Nombre} inició producción.");
            for (int i = 1; i <= TotalDeItems; i++)
            {
                ct.ThrowIfCancellationRequested();
                await Task.Delay(_rnd.Next(200, 1001), ct); // 200-1000 ms por pieza

                Producido = i;
                progressItems.Report(Producido);

                int pct = Producido * 100 / TotalDeItems;
                if ((pct == 25 || pct == 50 || pct == 75))
                    log($"{Nombre} alcanzó {pct} %.");
            }
            log($"{Nombre} completó producción");
        }
    }
}

