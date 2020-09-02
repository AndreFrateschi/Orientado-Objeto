using System;
namespace OOP
{
    public abstract class conta
    {

        public conta(int numero, double limite)
        {
            this.numero = numero;
            this.limite = limite;
            conta.totalContaCriada++;
            
        }
    

        protected double saldo { get; set; }

        public double limite { get; private set; }

        public double numero { get; private set; }

        public static int totalContaCriada { get; set; }

        public static int proximoTotalDeContasCriadas()
        {
            return conta.totalContaCriada + 1;
        }


        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();
            if(valor > saldoDisponivel)
            {
                Console.WriteLine("saldo indisponivel");
                return false; 
            }

             this.saldo -= valor;
            return true;
        }

        public void AdicionarLimite(double valor)
        {
            this.limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }




    }
}

