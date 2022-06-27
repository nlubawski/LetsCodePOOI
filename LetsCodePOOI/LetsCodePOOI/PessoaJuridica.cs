namespace LetesCodePOOI
{
    class PessoaJuridica : Contrato
    {
        public string Cnpj { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public PessoaJuridica(string contratante, decimal valor, int prazo, string cnpj, string inscricaoEstadual) : base(contratante, valor, prazo)
        {
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }

        public override decimal CalculaPrestacao()
        {
            const decimal taxa = 3;
            decimal valorPrestacao = Math.Round(Valor/Prazo + taxa, 2);
            return valorPrestacao;
        }
    }


}
