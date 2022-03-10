using System;
 
    internal class CalculadoraService
    {
        
        public  void Ejecutar()
        {
        int num1;
        int num2;
        int resultado;


        Console.WriteLine("Bienvenido a Nuestra Calculadora");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Introduzca el primer numero");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el segundo numero");
        num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Seleccione una opción de cálculo");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        int opcion = Int32.Parse(Console.ReadLine());
        }

        
    }
     







