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
            do
            {
                Console.WriteLine("Escribir numero de candidatos: ");
                _ncandidatos = int.Parse(Console.ReadLine());
                Console.Clear();
                validarint(_ncandidatos);
            } while (_ncandidatos <= 0);
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
            do
            {
                Console.WriteLine("Escribir numero de votantes: ");
                _nvotantes = int.Parse(Console.ReadLine());
                Console.Clear();
                validarint(_nvotantes);
            } while (_nvotantes <= 0);
        }
        public void votar()
        {
            for (int i = 1; i <= _nvotantes; i++)
            {
                do
                {
                    Console.WriteLine($"Votante {i}, Ingresar que candidato eliges: ");
                    _voto = int.Parse(Console.ReadLine());
                    if (_candidatos.Where(x => x.Id == _voto).Any())
                        _candidatos.First(x => x.Id == _voto).Votos += 1;
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

        public void validarint(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("El numero ingresado debe ser un entero");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
