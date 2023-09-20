int num1 = 0;
int num2 = 0;
int resultado = 0;

Console.WriteLine("Ingrese el primer numero a sumar");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero a sumar");
num2 = Convert.ToInt32(Console.ReadLine());

resultado = num1 + num2;
Console.WriteLine("El resultado es: " +  resultado);