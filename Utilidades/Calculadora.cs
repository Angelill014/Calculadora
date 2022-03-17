                                //14-02-22//
using System;

namespace Utilidades
{
    public  class Calculadora
    {
        
        public Calculadora()
        {
        
        }

        List<string> firstlist = new List<string> ()
        {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"
        };

        List<string> calculadora = new List<string>();
        calculadora.Add(InvalidTimeZoneException )
    
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
       public int Potencia(int numero1, int numero2)
        {
            int resultado;
            resultado = Math.Pow(numero1, numero2);
            Console.WriteLine(resultado);
        }
    } 
}

