using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {
        public static void Executar() {

            string nome = "Notebook gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O "+ nome + " da marca " //concatenação
            + marca+ " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", //interpolação com índice
            nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal"); //interpolação com dolar
            Console.WriteLine($"1 + 1 = {1+1}!");
        }
    }
}
