using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Questao2
{
    class Aluno : Usuario 
    {
        public void setFuncao(string funcao) { this.funcao = funcao; }
        public string getFuncao()
        {

            return funcao;
        }
        public string mostrarPapel()
        {
            return "eu sou um " + getFuncao();
        }
        public Aluno()
        {
            setMatricula();
        }
        public Aluno(string nome, string funcao, string email)
        {
            setNome(nome);
            setFuncao(funcao);
            setMatricula();
            setEmail(email);
        }
        public override void Emprestimos()
        {
            Console.WriteLine("limite de dias: 8");
        }
    }
}
