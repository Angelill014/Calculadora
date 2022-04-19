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
            Operaciones.Add(" El resultado de la suma es " + (resultado));
            Console.WriteLine(" El resultado de la suma es " + (resultado));
            return resultado;
        }
        public int Resta(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 - numero2;
            Operaciones.Add(" El resultado de la resta es " + (resultado));
            Console.WriteLine(" El resultado de la resta es " + (resultado));
            return resultado;
        }
        public int Multiplicacion(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 * numero2;
            Operaciones.Add(" El resultado de la multiplicacion es " + (resultado));
            Console.WriteLine(" El resultado de la multiplicacion es " + (resultado));
            return resultado;
        }
        public int Division(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 / numero2;
            Operaciones.Add(" El resultado de la division es " + (resultado));
            Console.WriteLine(" El resultado de la division es " + (resultado));
            return resultado;
        }
       public double Potencia(int numero1, int numero2)
        {
            double resultado;
            resultado = Math.Pow(numero1, numero2);
            Operaciones.Add(" El resultado de la potencia es " + (resultado));
            Console.WriteLine(" El resultado de la potencia es " + (resultado));
            return resultado;
        }
    } 
}

