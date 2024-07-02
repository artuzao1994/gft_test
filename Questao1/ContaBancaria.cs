namespace Questao1
{
    class ContaBancaria {
        public int Numero { get; }
        public string Titular { get; set; }
        public double DepositoInicial { get; set; }
        private double Saldo { get; set; }

        public const double Taxa = 3.50;
       
        public ContaBancaria(int Numero, string Titular, double DepositoInicial = 0.0)
        {
            this.Numero = Numero;
            this.Titular = Titular;
            this.DepositoInicial = DepositoInicial;

            if (DepositoInicial > 0.0) {
                Saldo = DepositoInicial;
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo =  (Saldo - valor) - Taxa;
            }
        }
    }
}
