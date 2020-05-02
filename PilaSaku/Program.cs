using System;

namespace PilaSaku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Programa de pila**************");
            var LaPila = new Pila<string>();

            Console.WriteLine("* Llenando la pila");
            LaPila.Add("nallely");
            LaPila.Add("lizardi");
            LaPila.Add("pacheco");
            LaPila.ShowItems();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("* Busqueda por valor");
            LaPila.FindByValue("lizardi");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("* Busqueda por indice");
            LaPila.ShowAt(2);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("* Eliminado el valor por indice");
            LaPila.RemoveAt(0);
            LaPila.ShowItems();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("* Cambiar elemento dado su indice");
            LaPila.AddAt("nallely nuevo", 0);
            LaPila.ShowItems();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("* Quitar de la pila el primer elemento");
            LaPila.PopFirstIn();
            LaPila.ShowItems();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("* Quitar de la pila el ultimo elemento");
            LaPila.PopLastIn();
            LaPila.ShowItems();

        }
    }
}
