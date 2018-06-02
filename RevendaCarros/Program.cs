using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevendaCarros.dominio;
using System.Globalization;

namespace RevendaCarros {
    class Program {

        public static List<Marca> listaMarca = new List<Marca>();
        public static List<Carro> listaCarro = new List<Carro>();

        static void Main(string[] args) {
            /*Inicializando com as marcas já cadastradas*/
            Marca m1 = new Marca(1001, "Volkswagens", "Alemanha");
            Marca m2 = new Marca(1002, "General Motores", "Estados Unidos");

            Carro c1 = new Carro(m1, 101, "Fusca", 1980, 5000.00);
            m1.addCarro(c1);
            Carro c2 = new Carro(m1, 102, "Golf", 2016, 60000.00);
            m1.addCarro(c2);
            Carro c3 = new Carro(m1, 103, "Fox", 2017, 30000.00);
            m1.addCarro(c3);
            Carro c4 = new Carro(m2, 104, "Cruze", 2016, 30000.00);
            m2.addCarro(c4);
            Carro c5 = new Carro(m2, 105, "Cobalt", 2015, 25000.00);
            m2.addCarro(c5);
            Carro c6 = new Carro(m2, 106, "Cobalt", 2017, 35000.00);
            m2.addCarro(c6);

            listaMarca.Add(m1);
            listaMarca.Add(m2);
            listaCarro.Add(c1);
            listaCarro.Add(c2);
            listaCarro.Add(c3);
            listaCarro.Add(c4);
            listaCarro.Add(c5);
            listaCarro.Add(c6);
            listaCarro.Sort();

            Menu.opcoes();
        }
    }
}
