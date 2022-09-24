﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaElseIf {
        public static void Executar() {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if(nota >= 9) {
                Console.WriteLine("Aluno no quadro de honra!");
            }
            else if(nota >= 7) {
                Console.WriteLine("Aluno está aprovado!");
            }
            else if(nota >= 5) {
                Console.WriteLine("Recuperação!");
            }
            else {
                Console.WriteLine("Te vejo na próxima!");
            }

            Console.WriteLine("Fim");
        }
    }
}
