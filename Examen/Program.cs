using Examen;
Console.ForegroundColor = ConsoleColor.Green;
Elecciones elecciones = new Elecciones();
elecciones.pedirCandidatos();
elecciones.pedirVotantes();
elecciones.votar();
elecciones.mostrarVotos();

