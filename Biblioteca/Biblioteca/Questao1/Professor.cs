using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Questao1
{
    class Professor : Usuario
    {
        public void setFuncao(string funcao) { this.funcao = funcao; }
        public string getFuncao() {
            return funcao;
        }
        public string mostrarPapel() {
            return "eu sou um " + getFuncao();
        }
        public Professor() {
            setMatricula();
        }
        public Professor(string nome, string funcao, string email) {
           setNome(nome);
           setFuncao(funcao);
           setMatricula();
            setEmail(email);
        }
    }
}
