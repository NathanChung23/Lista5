using System;
using System.Collections.Generic;

namespace Lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista
            List<int> numeros = new List<int>();
            while (numeros.Count < 5)
            {
                Console.WriteLine("Informe um número");
                int n = Convert.ToInt32(Console.ReadLine());
                numeros.Add(n);
            }
            Console.WriteLine("Original:");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Crescente:");
            numeros.Sort();
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Descrescente:");
            numeros.Reverse();
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total de Itens:");
            Console.WriteLine(numeros.Count);

            //Dicionario
            Dictionary<string, string> dicio = new Dictionary<string, string>();
            while (dicio.Count < 5)
            {
                Console.WriteLine("Digite o nome do site:");
                string site = Console.ReadLine();
                Console.WriteLine("Digite a url do site: ");
                string url = Console.ReadLine();
                dicio.Add(site, url);
            }
            int menu;
            do
            {
                Console.WriteLine("1 - Achar um site\n2 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Informe o nome do site a ser encontrado:");
                    string site = Console.ReadLine();
                    if (dicio.TryGetValue(site,out string value))
                    {
                        Console.WriteLine("Url: " + value);
                    }
                    else
                    {
                        Console.WriteLine("Site não encontrado");
                    }
                }
            } while (menu != 2);

            //Pilha
            menu = 0;
            Stack<int> pilha = new Stack<int>();
            do
            {
                Console.WriteLine("1-Inserir número\n2-Remover número\n3-Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Digite um número");
                    int n = Convert.ToInt32(Console.ReadLine());
                    pilha.Push(n);
                    foreach (int item in pilha)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (menu == 2)
                {
                    pilha.Pop();
                    foreach (int item in pilha)
                    {
                        Console.WriteLine(item);
                    }
                }
            } while (menu != 3);

            //Fila
            menu = 0;
            Queue<int> fila = new Queue<int>();
            do
            {
                Console.WriteLine("1-Inserir número\n2-Remover número\n3-Sair");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Digite um número");
                    int n = Convert.ToInt32(Console.ReadLine());
                    fila.Enqueue(n);
                    foreach (int item in pilha)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (menu == 2)
                {
                    fila.Dequeue();
                    foreach (int item in pilha)
                    {
                        Console.WriteLine(item);
                    }
                }
            } while (menu != 3);
        }
    }
}
