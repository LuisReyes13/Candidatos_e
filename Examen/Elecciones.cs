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
        private int[] candidatos;

        public void pedirCandidatos()
        {
            do
            {
                Console.WriteLine("Escribir numero de candidatos: ");
                _ncandidatos = int.Parse(Console.ReadLine());
                Console.Clear();
                validarint(_ncandidatos);
            } while (_ncandidatos <= 0);

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
            candidatos = new int[_ncandidatos];
            for (int i = 1; i <= _nvotantes; i++)
            {
                do
                {
                    Console.WriteLine($"Votante {i}, Ingresar que candidato eliges: ");
                    _voto = int.Parse(Console.ReadLine());
                    if (_voto <= _ncandidatos)
                        candidatos[_voto - 1]++;
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
            for (int i = 1; i <= _ncandidatos; i++)
            {
                Console.WriteLine($"Candidato {i} tiene : {candidatos[i - 1]} votos");
            }
            int max = candidatos.Max();
            int pos = mostrarGanador(candidatos, max, 0) + 1;
            if (candidatos.Length != candidatos.Distinct().Count())
                Console.WriteLine("No hay ningun ganador");

            else
                Console.WriteLine($"El ganador con {candidatos.Max()} votos, es el Candidato {pos}");
        }
        public static int mostrarGanador(int[] array, int elementob, int indice)
        {
            if (indice == array.Length)
                return -1;
            else if (array[indice] == elementob)
                return indice;
            else
                return mostrarGanador(array, elementob, indice + 1);
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
