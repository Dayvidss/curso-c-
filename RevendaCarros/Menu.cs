using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevendaCarros.dominio;
using System.Globalization;

namespace RevendaCarros {
    class Menu {
        
        public static int SAIR = 7;

        public static void opcoes() {
            int op = 0;
            while (op != SAIR) {
                Console.Clear();
                Console.WriteLine("1 – Listar marcas");
                Console.WriteLine("2 – Listar carros de uma marca ordenadamente");
                Console.WriteLine("3 – Cadastrar marca");
                Console.WriteLine("4 – Cadastrar carro");
                Console.WriteLine("5 – Cadastrar acessório");
                Console.WriteLine("6 – Mostrar detalhes de um carro");
                Console.WriteLine("7 – Sair");
                Console.Write("Digite uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        listaMarcas();
                        break;
                    case 2:
                        listaCarros();
                        break;
                    case 3:
                        cadastrarMarca();
                        break;
                    case 4:
                        cadastrarCarro();
                        break;
                    case 5:
                        cadastrarAcessorio();
                        break;
                    case 6:
                        mostrarDetalhes(Program.listaCarro);
                        break;
                    case 7:
                        op = SAIR;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public static void listaMarcas() {
            Console.Clear();
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for(int i =0; i < Program.listaMarca.Count; i++) {
                Console.WriteLine(Program.listaMarca[i]);
            }
            Console.ReadLine();
        }

        public static void listaCarros() {
            Console.Clear();
            Console.Write("Digite o códgio de um marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.listaMarca.FindIndex(x => x.codigo == codMarca);
            if(pos == -1) {
                throw new ModelException("Código da marca inexistente! " + codMarca);
            }
            Console.WriteLine("Carros da marca " + Program.listaMarca[pos].nome + " :");
            List<Carro> lista = Program.listaMarca[pos].carros;
            for(int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }

        public static void cadastrarMarca() {
            Console.Clear();
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codMarca = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nomeMarca = Console.ReadLine();
            Console.Write("País de origem: ");
            string paisOrigem = Console.ReadLine();
            Program.listaMarca.Add(new Marca(codMarca, nomeMarca, paisOrigem));
        }

        public static void cadastrarCarro() {
            Console.Clear();
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.listaMarca.FindIndex(x => x.codigo == codMarca);
            if(pos == -1) {
                throw new ModelException("Código da marca inexistente!");
            }
            Console.Write("Código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Marca M = Program.listaMarca[pos];
            Carro C = new Carro(M, codCarro, modelo, ano, precoBasico);
            M.addCarro(C);
            Program.listaCarro.Add(C);
            Program.listaCarro.Sort();
        }

        public static void cadastrarAcessorio() {
            Console.Clear();
            Console.WriteLine("Digite os dados do acessório:");
            Console.Write("Carro (código): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.listaCarro.FindIndex(x => x.codigo == codCarro);
            if(pos == -1) {
                throw new ModelException("Código do carro inexistente!");
            }
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double precoAc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Carro c = Program.listaCarro[pos];
            Acessorio a = new Acessorio(descricao, precoAc, c);
            c.acessorio.Add(a);
        }

        public static void mostrarDetalhes(List<Carro> carros) {
            Console.Clear();
            Console.Write("Digite o código do carro: ");
            int codCar = int.Parse(Console.ReadLine());
            int pos = carros.FindIndex(x => x.codigo == codCar);
            while(pos == -1) {
                Console.Clear();
                Console.WriteLine("Código do carro inexistente!");
                Console.Write("Digite o código do carro: ");
                codCar = int.Parse(Console.ReadLine());
                pos = carros.FindIndex(x => x.codigo == codCar);
            }
            Console.WriteLine(carros[pos]);
            Console.ReadLine();
        }
    }
}
