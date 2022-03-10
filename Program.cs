﻿using System;
namespace ProyectoCalculadora

{
   internal class Principal
   {
        CalculadoraService calculadoraService = new CalculadoraService();
        public Principal()
        {
            Console.WriteLine(calculadoraService.Ejecutar);
        }
   
        public static void Main(string[] args)
        {
          Calculadora calculadora = new Calculadora();
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
                Console.WriteLine("Su resultado es" + " " + Calculadora.Suma(num1, num2));
                break;

            case 2:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Resta(num1, num2));
                break;

            case 3:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Multiplicacion(num1, num2));
                break;

            case 4:
                Console.WriteLine("Su resultado es" + " " + Calculadora.Division(num1, num2));
                break;
                    
        }

           
        }
        
    
   }
}

