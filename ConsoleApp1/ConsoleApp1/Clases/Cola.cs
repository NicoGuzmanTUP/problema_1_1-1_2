using ConsoleApp1.Interfeces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Cola : IColleccion
    {
        private List<object> lista;
        public Cola()
        {
            lista = new List<object>();
        }

        public bool EstaVacia()
        {
            if (lista.Count == 0)
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
                object eEliminado = lista[0];
                lista.RemoveAt(0);

                return eEliminado;
            }
            else 
            {
                throw new InvalidOperationException("La Cola está vacía.");
            }
        }

        public object Primero()
        {
            if (!EstaVacia())
            {
                return lista[0];
            }
            else
            {
                throw new InvalidOperationException("La Cola está vacía.");
            }
        }

        public bool Añadir(object elemento)
        {
            lista.Add(elemento);

            return true;
        }
    }
}
