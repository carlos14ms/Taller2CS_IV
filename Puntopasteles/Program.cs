using System;
using System.Collections.Generic;
namespace Puntopasteles
{   
    public class Program {
    static void Main(string[] args)
    {
        // Crear pastel 1
        Pastel pastel = new Pastel("Panna cotta","grande");
        // crear ingredientes pastel 
        Ingrediente ingrediente1 = new Ingrediente("crema de leche", 2, 2500);
        Ingrediente ingrediente2 = new Ingrediente("Azúcar", 2, 2000);
        Ingrediente ingrediente3 = new Ingrediente("Gelatina", 1, 1500);
        Ingrediente ingrediente4 = new Ingrediente("vainilla", 1, 3000);

       // Agregar ingredientes pastel
        pastel.agregarIngrediente(ingrediente1);
        pastel.agregarIngrediente(ingrediente2);
        pastel.agregarIngrediente(ingrediente3);
        pastel.agregarIngrediente(ingrediente4);
        
        //Eliminar Ingredientes pastel
       /* pastel.EliminarIngrediente(ingrediente3); */

        // Mostrar información del pastel
        Console.WriteLine("Nombre del pastel: " + pastel.nombre);
        Console.WriteLine("Cantidad de ingredientes: " + pastel.cantidadDeIngredientes());
        Console.WriteLine("la Lista de ingredientes es:");
        Console.WriteLine(pastel.listarIngredientes());
        Console.WriteLine("El coste del pastel es: " +pastel.Costepastel() +"\n");

    }
    }
}
