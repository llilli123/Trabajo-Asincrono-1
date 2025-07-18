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
        // Nombre que le damos a la línea: “Línea Alpha”, “Beta”, etc.
        public string Nombre { get; }
        // Cantidad de piezas que queremos fabricar en total
        public int TotalDeItems { get; }
        // Contador que llevamos de cuántas piezas ya se hicieron.
        public int Producido { get; set; }
        // Como cada pieza tarda un tiempo variable, usamos este random para sacar un número al azar.
        private Random rnd = new();

        // Cuando creamos la línea, le decimos su nombre y cuántas piezas debe hacer
        public Produccion(string nombre, int totalDeItems)
        {
            Nombre = nombre;
            TotalDeItems = totalDeItems;
        }

        // Este método se lanza cuando pulsamos “Iniciar Producción”.
        // - progressItems: por dónde avisamos cuántas piezas llevamos
        // - log dónde escribimos mensajes (“Alcancé 25 %”), es un action tipo string por lo que toma un mensaje para guardarlo y mostrarlo como si fuera una variable
        // - ct el cancellation token para cancelar el metodo de ser pedido por el usuario
        
        public async Task RunAsync(IProgress<int> progressItems,Action<string> log, CancellationToken ct)
        {
            

            log($"{Nombre} inició producción."); // Avisamos por el registro que empezamos
            // Repetimos del 1 al total: un bucle,
            for (int i = 1; i <= TotalDeItems; i++)
            {
                ct.ThrowIfCancellationRequested();// Si alguien pulsó “Cancelar Produccion” se cancela
                await Task.Delay(rnd.Next(200, 1001), ct); // 200-1000 ms por pieza

                Producido = i;
                progressItems.Report(Producido);  // Avisamos fuera cuántas llevamos producidas, esto se lleva al pb
                 // Calculamos el porcentaje completado, esto lo usamos para imprimir los mensajes del registro de cada linea
                int pct = Producido * 100 / TotalDeItems;
                if ((pct == 25 || pct == 50 || pct == 75))
                    log($"{Nombre} alcanzó {pct} %.");
            }
            log($"{Nombre} completó producción"); // Fin de la línea
        }
    }
}

