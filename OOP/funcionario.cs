using System;
namespace OOP
{
    public abstract class funcionario
    {
        protected string nome{get; set;}

        public double salario { get; protected set;}

        public abstract void reajustar();

        public void adicionarNome(string primeiroNome, string sobreNome)
        {
            string nomeComleto = primeiroNome + sobreNome;
            this.nome = nomeComleto;
        }

        public void adicionarSalario(double salario)
        {
            this.salario = salario;
        }


    }
}
