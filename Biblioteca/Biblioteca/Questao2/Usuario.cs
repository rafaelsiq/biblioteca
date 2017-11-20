using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Questao2
{
    abstract class Usuario: IEmprestimo
    {
        private string nome;               
        private string email;
        private int matricula;
        protected string funcao;

        public void setNome(string nome)
        { this.nome = nome; }
        public string getNome() { return this.nome; }
        public int getMatricula()
        {
            return matricula;
        }
        protected void setMatricula() {
            Random random = new Random();
           this.matricula = random.Next(10000, 19999); ;
       }
        public string getEmail()
       {
         return email;
       }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public virtual void Emprestimos() {}
    }
}
