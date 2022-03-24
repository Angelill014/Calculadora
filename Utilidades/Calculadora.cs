                                          //14-02-22//
using System;

namespace Utilidades
{
    public class Calculadora 
    {
        public Calculadora();
        ///<sumary>
        /// Este metodo se utiliza para sumar dos numeros
        ///</sumary>
        ///<param name="numero1">Primer sumando</param>
        ///<param name="numero2">Segundo sumando</param>
        ///<returns>Resultado de suma</returns>
        public int Suma(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 + numero2;
            return resultado;
        }

        ///<sumary>
        /// Este metodo se utiliza para restar dos numeros
        ///</sumary>
        ///<param name="numero1">Primer resta</param>
        ///<param name="numero2">Segundo resta</param>
        ///<returns>Resultado de resta</returns>
        public int Resta(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 - numero2;
            return resultado;
        }

        ///<sumary>
        /// Este metodo se utiliza para multiplicar dos numeros
        ///</sumary>
        ///<param name="numero1">Primer multiplicado</param>
        ///<param name="numero2">Segundo multiplicado</param>
        ///<returns>Resultado de multiplicacion</returns>
        public int Multiplicacion(int numero1, int numero2)
        {
            int resultado;
            resultado = numero1 * numero2;
            return resultado;
        }

        ///<sumary>
        /// Este metodo se utiliza para dividir dos numeros
        ///</sumary>
        ///<param name="numero1">Dividendo</param>
        ///<param name="numero2">Divisor</param>
        ///<returns>Resultado de division</returns>
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

