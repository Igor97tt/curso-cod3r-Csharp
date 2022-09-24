using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            var nota = 9;
            bool bomComprtamento = true;
            string resultado = nota >= 7 && bomComprtamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
