using System;

class Program
{
    static void Main()
    {
        // Solicitar peso y altura
        Console.Write("Ingrese su peso en kilogramos: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calcular el IMC
        double imc = peso / (altura * altura);

        // Mostrar el resultado del IMC
        Console.WriteLine($"\nSu IMC es: {imc:F2}");

        // Clasificar el IMC según las categorías estándar
        if (imc < 18.5)
        {
            Console.WriteLine("Clasificación: Bajo peso");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Clasificación: Peso normal");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Clasificación: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Clasificación: Obesidad");
        }
    }
}
