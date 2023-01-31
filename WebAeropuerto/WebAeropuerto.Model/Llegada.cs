using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAeropuerto.Model
{
    public class Llegada
    {
        public int Id { get; set; }

        public TimeSpan Hora { get; set; }    

        public string Desde { get; set; }
        
        public string Vuelo_No { get; set;}
        public string Observacion { get; set; }


    }
}
