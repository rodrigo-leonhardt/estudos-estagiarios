using System;

namespace ExemploDelegates
{

    public class Delegados1
    {

        delegate void ResultadoDaSoma(int numero1, int numero2, int resultadoSoma);

        static void Somar(int numero1, int numero2, ResultadoDaSoma callbacks)
        {
            var resultado = numero1 + numero2;

            callbacks(numero1, numero2, resultado);
        }

        public static void Executar()
        {
            //Início do trecho para alteração
            ResultadoDaSoma del1 = ImprimirResultadoDaSoma1;
            ResultadoDaSoma del2 = ImprimirResultadoDaSoma2;
            ResultadoDaSoma delegados = del1 + del2;
            //Fim do trecho para alteração

            //O terceiro parâmetro é um MulticastDelegate
            Somar(1, 3, delegados);            
        }      
        
        static void ImprimirResultadoDaSoma1(int numero1, int numero2, int resultadoSoma)
        {
            Console.WriteLine($"O resultado da soma dos números {numero1} e {numero2} é {resultadoSoma}");
        }

        static void ImprimirResultadoDaSoma2(int numero1, int numero2, int resultadoSoma)
        {
            Console.WriteLine($"{resultadoSoma} é o resultado da soma dos números {numero1} e {numero2}");
        }

    }


}