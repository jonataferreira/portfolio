namespace Conta
{
    class CC
    {
        private int _cod;
        private int _id;
        private string _titular;
        private double _saldo;

        public double Saldo { get => _saldo; set => _saldo = value; }
        public string Titular { get => _titular; set => _titular = value; }
        public int Cod { get => _cod; private set => _cod = value; }
        public int Id { get => _id; private set => _id = value; }

        public CC(string titular, double saldo, int cod, int id)
        {

            this.Titular = titular;
            this.Saldo = saldo;
            this.Cod += 1;
            this.Id = id;

        }


        public CC(double saldo, int teste)
        { 
            if (teste == 2)
            {
                this.Saldo += saldo;
            }
            else
            {
                this.Saldo -= (5 + saldo);
            }


        }

        public override string ToString()
        {
            return "Titular da conta: " + _titular + "\nSaldo em conta: R$" + _saldo.ToString("F2") + Cod;
        }
    }
}
