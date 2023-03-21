using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class AvisoTrafico : IAvisos
    {
        private string remitente;

        private string mensaje;

        private string fecha;

        public AvisoTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de 3 días";
            fecha = "";
        }

        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string GetFecha() => this.fecha;

        public void MostrarAviso() =>
            Console.WriteLine($"Mensaje {mensaje} ha sido enviado por {remitente} el dia {fecha}");
    }
}
