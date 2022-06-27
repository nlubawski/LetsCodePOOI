using System;

namespace LetesCodePOOI
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string contratante;
            decimal valor;
            int prazo;

            Console.WriteLine("Contrato para: ");

            do
            {
                Console.WriteLine("Pessoa Física - 1");
                Console.WriteLine("Pessoa Jurídica - 2");
                opcao = Console.ReadLine();
            } while (!(opcao == "1" || opcao == "2"));
            
            do
            {
                Console.WriteLine("Nome:");
                contratante = Console.ReadLine();
            } while (string.IsNullOrEmpty(contratante));

            string valorStr;
            do
            {
                Console.WriteLine("Valor: ");
                valorStr = Console.ReadLine();
            } while (!decimal.TryParse(valorStr, out valor));

            string prazoStr;
            do
            {
                Console.Write("Prazo: ");
                prazoStr = Console.ReadLine();
            } while (!int.TryParse(prazoStr, out prazo));


            if (opcao == "1")
            {
                string cpf;
                string aniversario;
                DateTime dataAniversario;

                do
                {
                    Console.WriteLine("CPF:");
                    cpf = Console.ReadLine();
                } while (string.IsNullOrEmpty(cpf));

                do
                {
                    Console.Write("Data de nascimento:");
                    aniversario = Console.ReadLine();
                } while (!DateTime.TryParse(aniversario, out dataAniversario));

                PessoaFisica pessoaFisica = new PessoaFisica(contratante, valor, prazo, cpf, dataAniversario);

                pessoaFisica.ExibirInfo();

            }
            else
            {
                string cnpj;
                string inscricaoEstadual;

                do
                {
                    Console.WriteLine("CNPJ:");
                    cnpj = Console.ReadLine();
                } while (string.IsNullOrEmpty(cnpj));

                do
                {
                    Console.Write("Inscrição estadual:");
                    inscricaoEstadual = Console.ReadLine();
                } while (string.IsNullOrEmpty(inscricaoEstadual));

                PessoaJuridica pessoaJuridica = new PessoaJuridica(contratante, valor, prazo, cnpj, inscricaoEstadual);

                pessoaJuridica.ExibirInfo();
            }
        }
    }
}
