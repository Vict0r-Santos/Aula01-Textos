using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01Textos
{
    class Program
    {
        static void Main(string[] args)
        {
            //O Comando Console.WriteLine serve para exibir um texto
            //Porem se usado apenas Console.Write ele não pula uma linha e continua na atual
            Console.WriteLine("Olá Mundo!\n\n");
            Console.WriteLine("Ah Shit\nHere We go\nagain...");
            Console.WriteLine("\n\n\n\nMeu nome é Victor");
            Console.Write("Isso é Legal\n\n\n\n");
            //Comentarios no meio do código
            Console.WriteLine("Seja Bem-Vindo a \"melhor Cafeteria\" do mundo\n\n");
            Console.WriteLine("Essas são as nossas opções de hoje:\n" +
                "-Café puro sem açucar R$ 2,00\n" +
                "-Capuccino R$ 3,50\n" +
                "-Moccacino R$ 2.000,00");
            Console.WriteLine("\n\n\n\nEscolha uma das opções e dirija-se ao caixa:");
            //EU SOU O CORINGA HAHAHHAHHHAHAAHHAHAHAH
            // \n pula a linha


            Console.ReadKey();

        }
    }
}
