using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Elecciones
    {
        private int _ncandidatos;
        private int _nvotantes;
        private int _voto;
        private List<Candidato> _candidatos = new List<Candidato>();

        public void pedirCandidatos()
        {
            _ncandidatos = validarint("Escribe el numero de candidatos: ");
            Console.Clear();
            crearCandidatos();
        }

        public void crearCandidatos()
        {
            for (int n = 1; n <= _ncandidatos; n++)
            {
                _candidatos.Add(new Candidato() { Id = n });
            }

        }
        public void pedirVotantes()
        {
            _nvotantes = validarint("Escribir numero de votantes: ");
            Console.Clear();
        }
        public void votar()
            {
                for (int i = 1; i <= _nvotantes; i++)
                {
                    do
                    {
                        _voto = validarint($"Votante {i}, Ingresar que candidato eliges: ");
                        if (_candidatos.Where(x => x.Id == _voto).Any())
                            _candidatos.First(x => x.Id == _voto).sumarVoto();
                        else
                        {
                            Console.WriteLine("El candidato ingresado no existe");
                            Console.ReadLine();
                            _voto = 0;
                        }
                        Console.Clear();
                    } while (_voto <= 0);
                }
            }
            public void mostrarVotos()
            {
                foreach (Candidato c in _candidatos.OrderByDescending(x => x.Votos))
                {
                    Console.WriteLine($"Candidato {c.Id} tiene : {c.Votos} votos");
                }
                int maxVotos = _candidatos.Max(x => x.Votos);

                if (_candidatos.Count(x => x.Votos == maxVotos) > 1)
                    Console.WriteLine("No hay ganador, se encontraron candidatos empatados");

                else
                    Console.WriteLine($"El ganador con {maxVotos} votos, es el Candidato {_candidatos.First(x => x.Votos == maxVotos).Id}");
            }

            public int validarint(string mensaje)
            {
                int n;
                string vn;
                bool esNumero;

                do
                {
                    Console.Write(mensaje);
                    vn = Console.ReadLine();
                    esNumero = int.TryParse(vn, out n);
                    Console.Clear();
                    Console.WriteLine("El valor capturado, no es un numero entero");
                } while (!esNumero);
                return n;
            }
        } 
}
