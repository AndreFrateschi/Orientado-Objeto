using System;
namespace OOP
{
    public class contaPoupanca : conta , Iconta
    {
        public contaPoupanca(int numero, double limite) : base(numero, limite)
        {
            
        }

        public void mostrarNumeroDaConta()
        {
            Console.WriteLine(" a conta poupanca e :" + this.numero);
        }


        public override bool Saca(double valor)
        {
            bool deuCertooSaque = base.Saca(valor);

            if (deuCertooSaque)
            {
                this.saldo -= 6;
            }
            return false; 
        }



    }
}
