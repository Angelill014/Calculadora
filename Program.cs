using System;

public class Program
{
   public static void Main(String[] args)
   {
     EscribirMenu();
   }
        public static void EscribirMenu()
        {
         Console.WriteLine("Bienvenido A Mi Calculadora");
         Console.WriteLine("---------------------------");
         Console.WriteLine("Seleccione la opcion que desea");
         Console.WriteLine("1. Suma");
         Console.WriteLine("2. Resta");
         Console.WriteLine("3. Multiplicacion");
         Console.WriteLine("4. Division");
         Console.WriteLine("5. Salir");
         int opcion = Int32.Parse(Console.ReadLine());
        }
}
    
      