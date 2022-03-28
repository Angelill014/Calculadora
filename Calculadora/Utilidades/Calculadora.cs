                                //14-02-22//
using System;

namespace Utilidades
{
    public  class Calculadora
    {
        
        public Calculadora()
        {
            Operaciones = new List<string>();
        }

        public List<string> Operaciones {get; set;}
        
        public int Suma(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 + numero2;
            Operaciones.Add("Suma" + (numero1 + numero2) + "El resultado es" );
            return resultado;
        }
        public int Resta(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 - numero2;
            Operaciones.Add("Resta" + (numero1 - numero2) + "El resultado es" );
            return resultado;
        }
        public int Multiplicacion(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 * numero2;
            Operaciones.Add("Multiplicacion" + (numero1 * numero2) + "El resultado es" );
            return resultado;
        }
        public int Division(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 / numero2;
            Operaciones.Add("Division" + (numero1 / numero2) + "El resultado es" );
            return resultado;
        }
       public double Potencia(int numero1, int numero2)
        {
            double resultado;
            resultado = Math.Pow(numero1, numero2);
             return resultado;
        }
    } 
}

