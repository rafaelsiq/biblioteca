using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Testes;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questao 1:");
            questao1.Rodar();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Questao 2:");
            questao2.Rodar();
            Console.ReadKey();
        }
    }
}
