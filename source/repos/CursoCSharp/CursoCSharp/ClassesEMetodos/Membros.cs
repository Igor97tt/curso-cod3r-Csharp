using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Igor";
            pessoa.Idade = 0;

            //Console.WriteLine("{0} tem {1} anos de idade.", pessoa.Nome, pessoa.Idade);

            if(pessoa.Nome == "" || pessoa.Idade == 0) {
                Console.WriteLine("Dados inválidos, por favor insira-os novamente!");
            } else {
                pessoa.ApresentarNoConsole();
                pessoa.Zerar();
                pessoa.ApresentarNoConsole();
            }

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 35;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
