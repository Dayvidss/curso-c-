using System.Collections.Generic;

namespace RevendaCarros.dominio {
    class Marca {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        List<Carro> carros { get; set; }
        
        public Marca(int cod, string nome, string pais) {
            this.codigo = cod;
            this.nome = nome;
            this.pais = pais;
            carros = new List<Carro>();
        }

        public int totalCarros() {
            int total = 0;
            for(int i = 0; i < carros.Count; i++) {
                total++;
            }
            return total;
        }

        public override string ToString() {
            return "Código: " + codigo + ", Nome: " + nome + ", País: " + pais + ", Numeros de carros: " + totalCarros();
        }
    }
}
