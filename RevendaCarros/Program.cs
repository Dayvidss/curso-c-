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
        public static HashSet<Carro> listaCar = new HashSet<Carro>();

        static void Main(string[] args) {
            /*Inicializando com as marcas já cadastradas*/
            listaMarca.Add(new Marca(1001, "Volkswagens", "Alemanha"));
            listaMarca.Add(new Marca(1002, "General Motores", "Estados Unidos"));

            listaCarro.Add(new Carro(listaMarca[0], 101, "Fusca", 1980, 5000.00));
            listaCarro.Add(new Carro(listaMarca[0], 102, "Golf", 2016, 60000.00));
            listaCarro.Add(new Carro(listaMarca[0], 103, "Fox", 2017, 30000.00));
            listaCarro.Add(new Carro(listaMarca[1], 104, "Cruze", 2016, 30000.00));
            listaCarro.Add(new Carro(listaMarca[1], 105, "Cobalt", 2015, 25000.00));
            listaCarro.Add(new Carro(listaMarca[1], 106, "Cobalt", 2017, 35000.00));

            for (int i = 0; i < listaMarca.Count; i++) {
                Console.WriteLine(listaMarca[i]);
            }

            int count = 0;
            foreach (Carro x in listaCar) {
                count++;
            }

            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
