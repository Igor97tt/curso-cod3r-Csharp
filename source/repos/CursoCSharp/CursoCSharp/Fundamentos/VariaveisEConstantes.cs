using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            //área da circunferência

            double raio = 4.5;
            Console.WriteLine(raio); //apenas um testezin

            const double PI = 3.14;
            Console.WriteLine(PI); //apenas um testezin

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo "+ estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade é "+ idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols é "+saldoDeGols);

            var vezes = sbyte.MinValue * raio; //outro testezin
            Console.WriteLine(vezes);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é de "+salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor do int é de "+ menorValorInt); //mais usado dos inteiros

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira é de "+ populacaoBrasileira);

            uint maiorValorDoUint = uint.MaxValue;
            Console.WriteLine("Maior valor do uint é de "+ maiorValorDoUint);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor de long é de "+menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial é de "+populacaoMundial);

            float precoComputador = 7999.99f;
            Console.WriteLine("Preço do computador é de "+ precoComputador+" reais");

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //mais usado no mundo dos reais
            Console.WriteLine("Valor de mercado da Apple é de "+ valorDeMercadoDaApple);

            if(valorDeMercadoDaApple >= 10000) { //mais um testezin
                Console.WriteLine("É grana pra um caralho!!");
            }

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("A distância é de "+ distanciaEntreEstrelas+ " KM!");

            char letra = 'b';
            Console.WriteLine("Letra é "+ letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}   
