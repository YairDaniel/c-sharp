using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {

        //Declara una lista de cadenas 
        List<string> aves = new List<string> { "loro gris", "Paloma de diamante", "coctel" };
        Console.WriteLine("los valores de la lista antes de insertar:");
        //itera sobre la lista para imprimir los valores 
        foreach (string ave in aves)
        {
            Console.Write(ave + "");
        }
        Console.WriteLine();
        //Agrega tres valores al final de la lista utilizando el metodo Add()
        aves.Add("Mayna");
        aves.Add("periquitos");
        aves.Add("cacatua");
        Console.WriteLine("Los valores de la lista despues de insertar:");
        //Itera sobre la lista para imprimir los valores
        foreach (string ave in aves)
        {
            Console.Write(ave + "");
        }

        Console.WriteLine();

    }

}



