using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadora
{
   internal class Principal
   {

   
        public static void Main(String[] args)
        {
          int num1;
          int num2;
          int resultado;
          Calculadora calculadora = null;

          Console.WriteLine("Bienvenido a Nuestra Calculadora");
          Console.WriteLine("--------------------------------");
          Console.WriteLine("Introduzca el primer numero");
          num1 = Int32.Parse(Console.ReadLine());
          Console.WriteLine("Introduzca el segundo numero");
          num2 = Int32.Parse(Console.ReadLine());
          Console.WriteLine("Seleccione una opcion de calculo");
          Console.WriteLine("1. Suma");
          Console.WriteLine("2. Resta");
          Console.WriteLine("3. Multiplicacion");
          Console.WriteLine("4. Division");
          int opcion = Int32.Parse(Console.ReadLine());
          Calculadora.setNumero1(num1);

         switch (opcion)
         {
           case 1:
           resultado = num1 + num2;
           Console.WriteLine ("El resultado es: " + Calculadora.Suma ());
           break;
         
           case 2:
           resultado = num1 - num2;
           Console.WriteLine ("El resultado es: " + Calculadora.Resta ());
           break;

           case 3:
           resultado = num1 * num2;
           Console.WriteLine ("El resultado es: " + Calculadora.Multiplicacion ());
           break;

           case 4:
           resultado = num1 / num2;
           Console.WriteLine ("El resultado es: " + Calculadora.Division ());
           break;

           default:
           Console.WriteLine("La cantidad es incorrecta");
           Console.ReadLine();
           Console.WriteLine("La cantidad es correcta");
           break;
         }
         Console.ReadLine();
      }  
      
   }
    
}

   


    
      