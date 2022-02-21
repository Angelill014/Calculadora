                                //14-02-22//
using System;

public class Calculadora
{
    public static void Suma()
    {
       int numero1;
       int numero2;
       int resultado;
       Console.WriteLine("Introduzca el primer numero");
      numero1 = Int32.Parse (Console.ReadLine());
      Console.WriteLine("Introduzca el segundo numero");
      numero2 = Int32.Parse (Console.ReadLine());
      resultado = numero1 + numero2;
      Console.WriteLine(resultado);
    }

      public static void Resta()
       {
          int numero1;
          int numero2;
          int resultado;
          Console.WriteLine("Introduzca el primer numero");
          numero1 = Int32.Parse (Console.ReadLine());
          Console.WriteLine("Introduzca el segundo numero");
          numero2 = Int32.Parse(Console.ReadLine());
          resultado = numero1 - numero2;
          Console.WriteLine(resultado);

        }
    
    public static void Multiplicacion()
    {
       int numero1;
       int numero2;
       int resultado;
       Console.WriteLine("Introduzca el primer numero");
       numero1 = Int32.Parse (Console.ReadLine());
       Console.WriteLine("Introduzca el segundo numero");
       numero2 = Int32.Parse(Console.ReadLine());
       resultado = numero1 * numero2;
       Console.WriteLine(resultado);
    }

      public static void Division()
      {
          int numero1;
          int numero2;
          int resultado;
          Console.WriteLine("Introduzca el primer numero");
          numero1 = Int32.Parse(Console.ReadLine());
          Console.WriteLine("Introduzca el segundo numero");
          numero2 = Int32.Parse(Console.ReadLine());
          resultado = numero1 / numero2;
          Console.WriteLine(resultado);  
      }

}
    