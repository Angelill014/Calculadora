using System;

public class Program
{
    public static void Main(String[] args)
    {
      Calculadora calculadora = new Calculadora()
      Operación operación = new Operación();
      int opción = 0;
      while (opción != 5)
      {
          opción = Menu();
          if (opción == 1)
          {
              Console.Clear();
              operación = CrearOperación;
              calculadora.introducirOperación(operación);
          }
          else if (opción == 2)
          {
              Console.Clear();
              operación = CrearOperación;
              calculadora.introducirOperación(operación);
          }
          else if (opción == 3)
          {
              Console.Clear();
              operación = CrearOperación;
              calculadora.introducirOperación(operación);
          }
          else if (opción == 4)
          {
              Console.Clear();
              operación = CrearOperación;
              calculadora.introducirOperación(operación);
          }
      }     
    }
    public void Menu()
    {
        Console.WriteLine("BIENVENIDO A NUESTRA CALCULADORA");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Seleccione la opción que desea");
        Console.WriteLine("1. - Sumar");
        Console.WriteLine("2. - Restar");
        Console.WriteLine("3. - Multiplicar");
        Console.WriteLine("4. - Dividir");
        int opción = int.Parse(Console.ReadLine());
        while(RevisiónOpcionMenu(opción) == false)
        {
             Console.Clear();
                Console.WriteLine("Introduzca una opción valida por favor:");
               opción = Int32.Parse(Console.ReadLine());
        }
        return opción;
    }

    public static bool RevisiónOpcionMenu(int opción)
    {
        if (opción == 1)
        return true;
         else if (opción == 2)
                return true;
            else if (opción == 3)
                return true;
            else if (opción == 4)
                return true;
            else
                return false;
    }
}

