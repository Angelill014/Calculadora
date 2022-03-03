                                //14-02-22//
using ProyectoCalculadora;

public  class Calculadora
{
    enum ProyectoCalculadora
    {
        Suma,
        Resta,
        Multiplicación,
        División,
    }

    public static int Suma(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 + numero2;
        return resultado;
      
        
    }
    public static int Resta(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 - numero2;
        return resultado;
    }
    public static int Multiplicacion(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 * numero2;
        return resultado;
    }
    public static int Division(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 / numero2;

        return resultado;
    }
  
    
}

