using System;
namespace ProyectoCalculadora;

public class Program
{
    public static void Main(string[] args)
    {
        int numero1;
        int numero2;
        int resultado;
        Calculadora calculadora = new Calculadora();

            Console.WriteLine("BIENVENIDO A NUESTRA CALCULADORA");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Introduce el primer número");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la opción que desea");
            Console.WriteLine("1. - Sumar");
            Console.WriteLine("2. - Restar");
            Console.WriteLine("3. - Multiplicar");
            Console.WriteLine("4. - Dividir");
            int opción = Int32.Parse(Console.ReadLine());

        switch (opción)
        {
            case 1:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Suma(numero1, numero2));
                break;

            case 2:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Resta(numero1, numero2));
                break;

            case 3:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Multiplicacion(numero1, numero2));
                break;

            case 4:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Division(numero1, numero2));
                break;
        }
    }
}