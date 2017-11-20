using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Questao1;

namespace Biblioteca.Testes
{
    class questao1
    {
        static public void Rodar() {
            Console.WriteLine("--------------------Mostrar Usuarios--------------------");

            Aluno aluno = new Aluno("Rafael", "aluno", "rafaelsqf@gmail.com");
            Professor professor = new Professor("Cintia", "Professor", "cintia@gmail.com");
            Bibliotecario bibliotecario = new Bibliotecario("Carlos", "Bibliotecario", "carlos@pucminas.br");

            Console.WriteLine(aluno.getNome()+"\t| "+ aluno.getEmail() + "\t| " + aluno.mostrarPapel());
            Console.WriteLine(professor.getNome() + "\t| " + professor.getEmail() + "\t| " + professor.mostrarPapel());
            Console.WriteLine(bibliotecario.getNome() + "\t| " + bibliotecario.getEmail() + "\t| " + bibliotecario.mostrarPapel());
        }
    }
}
