using ConsoleApp1.Clases;
using System;

class Program
{
    static void Main()
    {
        Pila oPila = new Pila(capacidad: 8);
        Cola oCola = new Cola();

        oPila.Añadir(1);
        oCola.Añadir(1);

        Console.WriteLine($"El primer elemento es {oPila.Primero()}");

        Console.WriteLine($"El primer elemento es {oCola.Primero()}");

    }
}
