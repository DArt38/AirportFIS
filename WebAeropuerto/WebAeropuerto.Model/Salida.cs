using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAeropuerto.Model
{
    public class Salida
    {
        public int Id { get; set; }

        public TimeSpan Hora { get; set; }

        public string Hasta { get; set; }

        public string Vuelo_No { get; set; }

        public string Puerta { get; set; }
        public string Observaciones { get; set; }
    }
}
