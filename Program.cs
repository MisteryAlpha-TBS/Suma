int numero = 0;
int resultado = 0;
int ejecuciones = 0;


Console.WriteLine("Cuantos números esea sumar?");
ejecuciones = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < ejecuciones; i++)
{

    Console.WriteLine("Ingrese el numero (" + (i + 1) + "): ");
    numero = Convert.ToInt32(Console.ReadLine());
    resultado += numero;

}

Console.WriteLine("El resultado es: " + resultado);