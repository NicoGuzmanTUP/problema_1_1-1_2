using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleApp1.Interfeces;

namespace ConsoleApp1.Clases
{
    public class Pila : IColleccion
    {
        private object[] elementos;
        private int contador;

        public Pila(int capacidad)
        {
            elementos = new object[capacidad];
            contador = 0;
        }

        public bool EstaVacia()
        {
            if(contador == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Extraer()
        {            
            if (!EstaVacia())
            {
               int eElemento = contador;
               contador--;
               return elementos[eElemento];
            }

            throw new InvalidOperationException("La pila está vacía.");
        }

        public object Primero()
        {
            if (!EstaVacia())
            {
                return elementos[contador -1];
            }

            throw new InvalidOperationException("La pila está vacía.");
        }

        public bool Añadir(object elemento)
        {
            if (contador >= elementos.Length)
            {
                return false ;
            }
            elementos[contador] = elemento;
            contador++;
            return true;
            
        }
    }
}
