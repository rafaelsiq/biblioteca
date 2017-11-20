using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Questao2;
using System.Threading.Tasks;

namespace Biblioteca.Testes
{
    class questao2
    {
        static public void Rodar() {
            Console.WriteLine("------------Mostrar Limite de Dias por Tipo------------");

            Aluno aluno = new Aluno("Rafael", "aluno", "rafaelsqf@gmail.com");
            Professor professor = new Professor("Cintia", "Professor", "cintia@gmail.com");
            Bibliotecario bibliotecario = new Bibliotecario("Carlos", "Bibliotecario", "carlos@pucminas.br");

            Console.Write(aluno.mostrarPapel()+ "\t| "); aluno.Emprestimos();
            Console.Write(professor.mostrarPapel()+ "\t| "); professor.Emprestimos();
            Console.Write(bibliotecario.mostrarPapel() + "\t| "); bibliotecario.Emprestimos();


        }

    }
}
