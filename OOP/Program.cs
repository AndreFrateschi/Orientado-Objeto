using System;

namespace OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("aprendendo oop");


            analistaDeTi analistaDeTi = new analistaDeTi();

            analistaDeTi.adicionarNome("andre", "Frateschi");
            analistaDeTi.adicionarSalario(1000);

            analistaDeTi.reajustar();

            Console.WriteLine("o salario foi reajustado para: " + analistaDeTi.salario);







            //contaPoupanca contaPoupanca = new contaPoupanca(123, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Saca(10);
            //double saldoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();


            //Console.WriteLine("saldo da poupanca e: " + saldoPoupanca);




            //contaCorrente contaCorrente = new contaCorrente(123, 0);

            //contaCorrente.Deposita(100);
            //contaCorrente.Saca(10);
            //double saldoCorrente = contaCorrente.ConsultaSaldoDisponivel();


            //Console.WriteLine("saldo da poupanca e: " + saldoCorrente);








            // analistaDeTi analistaDeTi = new analistaDeTi();
            // gerente gerente = new gerente();
            // gerenteDeAgencia gerenteDeAgencia = new gerenteDeAgencia();
            // gerenteDeTi gerenteDeTi = new gerenteDeTi();


            // analistaDeTi.nome = "andre";

            //  analistaDeTi.salario = 3000;

            // Console.WriteLine("analista de ti e: " + analistaDeTi.salario);

            // analistaDeTi.reajustar();

            // Console.WriteLine("salario reajustado e: " + analistaDeTi.salario);


            // Console.WriteLine("...............");






            // gerente.nome = "zezao";

            // gerente.salario = 8000;

            // Console.WriteLine("gerente e: " + gerente.salario);

            // gerente.reajustar();

            // Console.WriteLine("salario reajustado e: " + gerente.salario);


            // Console.WriteLine("...............");



            // gerenteDeAgencia.nome = "zezinho";

            // gerenteDeAgencia.salario = 10000;

            // Console.WriteLine("gerente de agencia e: " + gerenteDeAgencia.salario);

            // gerenteDeAgencia.reajustar();

            // Console.WriteLine("salario reajustado e: " + gerenteDeAgencia.salario);

            // Console.WriteLine("...............");



            // gerenteDeTi.nome = "zeza";

            // gerenteDeTi.salario = 20000;

            // Console.WriteLine("gerente de agencia e: " + gerenteDeTi.salario);

            // gerenteDeTi.reajustar();

            // Console.WriteLine("salario reajustado e: " + gerenteDeTi.salario);

            // Console.WriteLine("...............");



            //contaPoupanca contaPoupanca = new contaPoupanca(123, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Saca(10);

            //double saldo = contaPoupanca.ConsultaSaldoDisponivel();

            //contaPoupanca.mostrarNumeroDaConta();


            //Console.WriteLine("saldo e: " + saldo);


            //conta conta = new conta (111, 100);

            //conta.Deposita(500);
            //conta.Saca(140);

            //double saldoContaCorrente = conta.ConsultaSaldoDisponivel();

            //Console.WriteLine("saldo e: " + saldoContaCorrente);


            //conta conta1 = new conta(123, 500);
            //conta conta2 = new conta(456, 100);
            //conta conta3 = new conta(678, 200);
            //conta conta4 = new conta(234, 500);

            //Console.WriteLine("total: " + conta.totalContaCriada);

            //int totalProximo = conta.proximoTotalDeContasCriadas();

            //Console.WriteLine("proxima conta: " + totalProximo);



            //criando um ojeto de cada classe

            //cartaoDeCredito cdc = new cartaoDeCredito();
            //cliente c = new cliente();

            // adicioando o nome do cliente

            //c.nome = "Andre";

            //adicioanndo o numero e data de validade do cartao

            //cdc.Numero = "123";

            //cdc.dataDeValidade = "01/2020";

            //cdc.cliente = c;


            //Console.WriteLine("seu nome e: " + c);
            //Console.WriteLine("o numero do carto e:" + cdc.Numero);
            //Console.WriteLine("a data de validade e: " + cdc.dataDeValidade);
            //Console.WriteLine("o nome do cliente agredado e: " + cdc.cliente.nome);



















            //criando instancia de conta

            //conta conta = new conta(123);

            //conta.AdicionarLimite(1500);

            //conta.Deposita(1500);
            //conta.Deposita(200);
            //conta.Deposita(100);

            //bool saca = conta.Saca(100);
            //if(saca)
            // {

            //                double saldo = conta.ConsultaSaldoDisponivel();
            //
            //               Console.WriteLine(saldo);
            //             Console.WriteLine("O seu limite e: " + conta.limite);
            //    Console.WriteLine("o numero da minha conta e: " + conta.numero);

            // }



        }
    }
}




//using System;

//amespace OOP
//{
   // class MainClass
    //{
     //   public static void Main(string[] args)
      //  {

        //    Console.WriteLine("aprendendo oop");

            //criando instancia de conta

          //  conta conta1 = new conta();

            //criando a segunda instancia da conta 

            //conta conta2 = new conta();

            //incluindo divisoria no console
            //Console.WriteLine("                        ");

            // atribundo valores para conta 1
            //conta1.saldo = 1500;
            //conta1.limite = 500;
            //conta1.numero = 123;

            //atibundo valores para conta 2 
            //conta2.saldo = 20000;
            //conta2.limite = 100;
            //conta2.numero = 1234;

            // gerando informacao no console da conta 1 
//            Console.WriteLine("ola, andre o saldo da sua conta e: " + conta1.saldo);
  //          Console.WriteLine("o seu limite para saque e: " + conta1.limite);
    //        Console.WriteLine("o numero da sua conta e: " + conta1.numero);

            //incluindo divisoria no console
      //      Console.WriteLine("                        ");
            
            // gerando incolecao no contole da conta 2
        //    Console.WriteLine("ola, andre o saldo da sua conta e: " + conta2.saldo);
         //   Console.WriteLine("o seu limite para saque e: " + conta2.limite);
         //   Console.WriteLine("o numero da sua conta e: " + conta2.numero);

        //}
   // }
