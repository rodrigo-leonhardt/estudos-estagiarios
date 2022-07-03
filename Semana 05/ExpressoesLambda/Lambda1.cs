using System;

namespace ExemploLambda
{

    public class Lambda1
    {
        delegate int Somar(int valor1, int valor2);

        public static void Executar()
        {
            int x = 1;
            int y = 3;

            //Delegado + Função anônima
            Console.WriteLine("Usando função anônima");

            Somar funcaoAnonima = delegate(int valor1, int valor2) {
                return valor1 + valor2;
            };

            int z = funcaoAnonima(x, y);

            Console.WriteLine($"{x} + {y} = {z}");


            //Delegado + Expressão Lambda
            Console.WriteLine("Usando função lambda");

            //Início do trecho para aleração
            Somar funcaoLambda = (val1, val2) => val1 + val2;
            //Fim do trecho para aleração

            z = funcaoLambda(x, y);

            Console.WriteLine($"{x} + {y} = {z}");
        }
 
    }

}