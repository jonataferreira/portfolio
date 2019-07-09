using System;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            Console.WriteLine("Digite o número da operação: 1 - Inclusão; 2 - Depósito; 3 - Saque; ou qualquer outro valor para sair");
            int teste = int.Parse(Console.ReadLine());


            if (teste == 1)
            {
                Console.WriteLine("Digite a Identidade do correntista");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome completo do correntista");
                string Titular = Console.ReadLine();
                Console.WriteLine("O valor de depósito inicial");
                double Saldo = Double.Parse(Console.ReadLine());
                int cod = 0;

                CC c;
                c = new CC(Titular, Saldo, cod, id);
                Console.WriteLine(c);
            }

            if (teste == 2)
            {

                Console.WriteLine("Digite o valor do depósito");
                double Saldo = Double.Parse(Console.ReadLine());
                CC c = new CC(Saldo, teste);
                Console.WriteLine(c);
            }

            if (teste == 3)
            {
                Console.WriteLine("O valor do Saque (haverá uma cobrança de R$5,00)");
                double Saldo = (Double.Parse(Console.ReadLine()));
                CC c;
                c = new CC(Saldo, teste);

                Console.WriteLine(c);
            }


            else
            {
                Console.WriteLine("O BANCO XXXXX AGRADECE!");
            }


        }
    }
}
