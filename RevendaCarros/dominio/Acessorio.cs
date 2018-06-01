using System.Globalization;

namespace RevendaCarros.dominio {
    class Acessorio {
        public string descricao { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio(string desc, double preco, Carro carro) {
            this.descricao = desc;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString() {
            return descricao + ", Preço: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
