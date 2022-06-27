namespace LetesCodePOOI
{
    class PessoaFisica : Contrato
    {
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public int Idade { get; private set; }

        public PessoaFisica(string contratante, decimal valor, int prazo, string cpf, DateTime dataNascimento) : base(contratante, valor, prazo)
        {
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Idade = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                Idade -= 1;
            }
        }

        //private int CalcularIdade()
        //{
        //    idade = DateTime.Now.Year - dataNascimento.Year;

        //    if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
        //    {
        //        idade--;
        //    }

        //    return idade;
        //}
        public override decimal CalculaPrestacao()
        {
            decimal taxa;

            if (Idade <= 30)
            {
                taxa = 1;
            }
            else if (Idade <= 40)
            {
                taxa = 2;
            }
            else if (Idade <= 50)
            {
                taxa = 3;
            }
            else
            {
                taxa = 4;
            }
            decimal valorPrestacao = Math.Round(Valor / Prazo + taxa, 2);
            return valorPrestacao;
        }

        public override void ExibirInfo()
        {
            Console.Clear();
            Console.WriteLine("Informações");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Prazo: {Prazo}");
            Console.WriteLine($"Parcela: {CalculaPrestacao()}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
