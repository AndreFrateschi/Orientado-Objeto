using System;
namespace OOP
{
    public interface Iconta
    {
        void Deposita(double valor);
        bool Saca(double valor);
        void AdicionarLimite(double valor);
        double ConsultaSaldoDisponivel();



     }


}
