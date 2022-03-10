                                //14-02-22//
using System;

namespace Utilidades;

public  class Calculadora
{
    public Calculadora()
    {
        
    }
    
    public int Suma(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 + numero2;
        return resultado;
      
        
    }
    public int Resta(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 - numero2;
        return resultado;
    }
    public int Multiplicacion(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 * numero2;
        return resultado;
    }
    public int Division(int numero1, int numero2)
    {
        int resultado;
        resultado = numero1 / numero2;

        return resultado;
    }
}

