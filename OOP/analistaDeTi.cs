using System;
namespace OOP
{
    public class analistaDeTi : funcionario
    {
        public analistaDeTi()
        {
        }

        public override void reajustar()
        {
            this.salario += 700;
        }
    }
}
