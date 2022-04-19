using System;
using Utilidades;

internal class CalculadoraService
    {
        public Calculadora MiCalculadora { get; set; }
        public CalculadoraService()
        {
            MiCalculadora = new Calculadora();
        }
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

            switch (opcion)
            {
                case 1:
                   MiCalculadora.Suma(num1, num2);
                    break;

                case 2:
                    MiCalculadora.Resta(num1, num2);
                    break;

                case 3:
                    MiCalculadora.Multiplicacion(num1, num2);
                    break;

                case 4:
                    MiCalculadora.Division(num1, num2);
                    break;

            }
        }
    }
     







