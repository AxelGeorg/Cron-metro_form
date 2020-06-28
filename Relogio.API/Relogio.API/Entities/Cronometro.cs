using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relogio.API.Entities
{
    public class Cronometro
    {
        public Cronometro(string id, string data, string horario, string tempo)
        {
            this.cro_id = id;
            this.cro_data = data;
            this.cro_horario = horario;
            this.cro_tempo = tempo;
        }
        public Cronometro()
        {
        }

        public string cro_id { get; set; }
        public string cro_data { get; set; }
        public string cro_horario { get; set; }
        public string cro_tempo { get; set; }
    }
}
