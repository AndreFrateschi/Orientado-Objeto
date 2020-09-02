using System;
namespace OOP
{
    public class gerenteDeAgencia : gerente 
    {
        public override void reajustar()
        {
            this.salario += 1200;
        }
    }
}
