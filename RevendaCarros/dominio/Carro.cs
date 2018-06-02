using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RevendaCarros.dominio {
    class Carro : IComparable{
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int anoDeFabricacao { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }
        public List<Acessorio> acessorio;

        public Carro(Marca marca, int codCarro, string modelo, int ano, double preco) {
            this.codigo = codCarro;
            this.modelo = modelo;
            this.anoDeFabricacao = ano;
            this.precoBasico = preco;
            this.marca = marca;
            acessorio = new List<Acessorio>();
        }

        public double valorTotal() {
            double soma = precoBasico;
            for(int i = 0; i < acessorio.Count; i++) {
                soma = soma + acessorio[i].preco;
            }
            return soma;
        }

        public override string ToString() {
            string s = codigo + ", " + modelo + ", Ano: " + anoDeFabricacao 
                + ", Preço Básico: R$ " + precoBasico.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Preço total: R$" + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
            if(acessorio.Count > 0) {
                s = s + "\nAcessórios:\n";
                for (int i = 0; i < acessorio.Count; i++) {
                    s = s + acessorio[i];
                }
            }
            return s;
        }

        public int CompareTo(object obj) {
            Carro outro = (Carro)obj;
            int resultado = modelo.CompareTo(outro.modelo);
            if(resultado != 0) {
                return resultado;
            } else {
                return -precoBasico.CompareTo(outro.precoBasico);
            }
        }
    }
}
