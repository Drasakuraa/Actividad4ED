using System;
using System.Collections.Generic;
using System.Text;

namespace PilaSaku
{
    public class Pila<T>
    {
        private Array Data { get; set; }

        public Pila()
        {
            Data = Array.CreateInstance(typeof(T), 0);
        }
        public void ShowItems() //Aqui hace el recorrido 
        {
            Console.WriteLine("| Lenght: " + Data.Length);
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine("| [" + i + "] : " + Data.GetValue(i));
            }
        }

        public void ShowAt(int index) //Busca un elemento por su indice
        {
            if (index < Data.Length)
                Console.WriteLine("[" + index + "] : " + Data.GetValue(index));
            else
                Console.WriteLine("Index doesn't exist: [" + index + "]");
        }

        public void FindByValue(T value)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data.GetValue(i).ToString() == value.ToString())
                    Console.WriteLine("Found: [" + i + "] : " + Data.GetValue(i));
            }
        }

        public void AddAt(T value, int index) //Agrega un elemento en el indice indicado
        {
            if (index < Data.Length)
                Data.SetValue(value, index);
            else
            {
                var tmp = Array.CreateInstance(typeof(T), Data.Length + 1);
                Data.CopyTo(tmp, 0);
                tmp.SetValue(value, index);
                Data = tmp;
            }
        }

        public void Add(T value) //Agrega un elemento al final de la pila
        {
            AddAt(value, Data.Length);
        }

        public void RemoveAt(int index) //borra un elemento en el indice indicado
        {
            Data.SetValue(default(T), index);
        }

        public void PopFirstIn() //bota el primer elemento de la pila FIFO
        {
            if (Data.Length > 0)
            {
                Data.SetValue(default(T), 0);
                var tmp = Array.CreateInstance(typeof(T), Data.Length - 1);
                Array.Copy(Data, 1, tmp, 0, tmp.Length);
                Data = tmp;
            }
            else
            {
                Console.WriteLine("No data");
            }
        }

        public void PopLastIn() //bota el ultimo elemento de la pila, FILO
        {
            if (Data.Length > 0)
            {
                var tmp = Array.CreateInstance(typeof(T), Data.Length - 1);
                Array.Copy(Data, 0, tmp, 0, tmp.Length);
                Data = tmp;
            }
            else
            {
                Console.WriteLine("No data");
            }
        }

    }
}
