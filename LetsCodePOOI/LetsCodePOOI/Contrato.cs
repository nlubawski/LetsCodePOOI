namespace LetesCodePOOI
{
    class Contrato
    {
        public Guid IdContrato { get; private set; }
        public string Contratante { get; private set; }
        public decimal Valor { get; private set; }
        public int Prazo { get; private set; }

        public Contrato(string contratante, decimal valor, int prazo)
        {
            IdContrato = Guid.NewGuid();
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual decimal CalculaPrestacao()
        {
            return Valor / Prazo;
        }

        public virtual void ExibirInfo()
        {
            Console.Clear();
            Console.WriteLine("Informações");
            Console.WriteLine($"Valor: {Valor}");
            Console.WriteLine($"Prazo: {Prazo}");
            Console.WriteLine($"Parcela: {CalculaPrestacao()}");
        }
    }
}
