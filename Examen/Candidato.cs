using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Candidato
    {
        public int Id { get; set; }
        public int Votos { get; set; }

        public void sumarVoto()
        {
            Votos++;
        }

    }
}
