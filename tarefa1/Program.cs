using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Conta conta = new Conta();
            ContaPoupanca contaPoupanca = new ContaPoupanca();


            cliente.Nome = "Gustavo";

            conta.Agência = 0123;

            contaPoupanca.DiaDeposito = DateTime.Today;



            Console.WriteLine(cliente.Nome);

            Console.WriteLine(conta.Agência);

            Console.WriteLine(contaPoupanca.DiaDeposito);
        }
    }
}
