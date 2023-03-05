// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
 * orden numeros descendente multiplos de 5 del 1 al 100
int i = 101;
while (i >= 1)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }

    i--;
}*/

/*
 * sumatoria de numeros multiplos de 5 del 1 al 100
int i = 1,n = 0;
while (i <= 100)
{
    if (i % 5 == 0)
    {
        n = n + i;
    }
    i++;
}
Console.WriteLine("La suma es: " + n);
*/


//* ordenar arreglo de numeros
/*
int[] numeros = { 250, 100, 23, 145, 122, 432, 107, 109, 265, 194, 1 };
Array.Sort(numeros);
while( int i< numeros.Length;)
{
    Console.WriteLine(numeros[i]);
}
*/

/*
int i = 100, n = 0;
while (i >= 1)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
    i--;
}
*/


/*  candidatos
 *  
int ncandidatos, nvotantes, voto;

Console.WriteLine("Escribir numero de candidatos: ");
ncandidatos = int.Parse(Console.ReadLine());
Console.Clear();

    int[] candidatos = new int[ncandidatos];

Console.WriteLine("Escribir numero de votantes: ");
nvotantes = int.Parse(Console.ReadLine());
Console.Clear();


for (int i = 1; i <= nvotantes; i++)
    {
        Console.WriteLine("Votante " + i + ", Ingresar que candidato eliges: ");
        voto = int.Parse(Console.ReadLine());
        candidatos[voto-1]++;
        Console.Clear();
    }


for (int i = 1; i <= ncandidatos; i++)
{
    Console.WriteLine("Candidato " + i + " tiene " + candidatos[i - 1] + " votos");
}
    Console.WriteLine("El ganador con " + candidatos.Max() + " votos, es el candidato ");
*/

using Examen;

Elecciones elecciones = new Elecciones();
elecciones.pedirCandidatos();
elecciones.pedirVotantes();
elecciones.votar();
elecciones.mostrarVotos();

