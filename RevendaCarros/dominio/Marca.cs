using System.Collections.Generic;

namespace RevendaCarros.dominio {
    class Marca {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carros;
        
        public Marca(int cod, string nome, string pais) {
            this.codigo = cod;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }

        public void addCarro(Carro c) {
            carros.Add(c);
            carros.Sort();
        }

        public override string ToString() {
            return "Código: " + codigo + ", Nome: " + nome + ", País: " + pais + ", Numeros de carros: " + carros.Count;
        }
    }
}
