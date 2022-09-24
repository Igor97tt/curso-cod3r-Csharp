using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {

            var nome = "Igor"; //houve inferência
            Console.WriteLine(nome);
            //nome = 123;

            /*
            quando uma variável é do tipo "var" (implícita), é obrigatório inicializar ela para o C#
            fazer a inferência
            */

            var idade = "32";
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
;