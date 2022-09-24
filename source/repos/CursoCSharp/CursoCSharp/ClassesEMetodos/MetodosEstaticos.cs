using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    internal class CalculadoraEstatica {

        // Método de classe ou método estático!!
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        // Método de instância!!
        public int Somar(int a, int b) {
            return a + b;
        }
    }
    internal class MetodosEstaticos {
        public static void Executar() {
            //Aqui é uso de método de classe, ou seja, sem precisar instanciar/criar um novo objeto!
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);
            //OU
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 2));

            //Aqui é uso de método de instância!
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2)); 
        }
    }
}
