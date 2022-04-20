using System;
using System.Collections.Generic;

namespace FilaEPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simulando Fila
            Console.WriteLine("> Utilização de Queue (FIFO - First In First Out)");

            var filaClientes = new Queue<string>();
            AdicionarItens(filaClientes);
            RemoverItens(filaClientes);

            //Simulando Pilha
            Console.WriteLine("> Utilização de Stack (LIFO - Last In First Out)");

            var pilhaClientes = new Stack<string>();
            AdicionarItens(filaClientes);
            RemoverItens(filaClientes);
        }

        static void AdicionarItens(IReadOnlyCollection<string> itens)
        {
            Console.WriteLine("Incluindo itens");

            AdicionarItem(itens, "João");
            AdicionarItem(itens, "Maria");
            AdicionarItem(itens, "Cláudio");
        }

        static void RemoverItens(IReadOnlyCollection<string> itens)
        {
            Console.WriteLine("Removendo itens");

            while (itens.Count > 0)
            {
                var itemRemovido = RemoverItem(itens);

                Console.WriteLine($"Removido item {itemRemovido}");
            }
        }

        //Usando Generics
        static void AdicionarItem<T>(IReadOnlyCollection<T> itens, T item)
        {
            if (itens is Queue<T> fila)
                fila.Enqueue(item);
            else if (itens is Stack<T> pilha)
                pilha.Push(item);
            else
                throw new NotImplementedException();

            Console.WriteLine($"Incluído item {item}");
        }

        //Usando Generics
        static T RemoverItem<T>(IReadOnlyCollection<T> itens)
        {
            if (itens is Queue<T> fila)
                return fila.Dequeue();

            if (itens is Stack<T> pilha)
                return pilha.Pop();

            throw new NotImplementedException();
        }
    }
}