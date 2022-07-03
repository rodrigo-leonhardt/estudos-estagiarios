using System;
using System.Collections.Generic;

namespace Dicionario
{
    class Program
    {
        static Dictionary<int, string> diasDaSemana = new();

        static void Main(string[] args)
        {
            AdicionarDiaDaSemana(3, "Terça-feira");
            AdicionarDiaDaSemana(1, "Domingo");
            AdicionarDiaDaSemana(5, "Quinta-feira");
            AdicionarDiaDaSemana(2, "Segunda-feira");
            AdicionarDiaDaSemana(6, "Sexta-feira");
            AdicionarDiaDaSemana(4, "Quarta-feira");            
            AdicionarDiaDaSemana(7, "Sábado");            

            ConsultarNomeDoDiaDaSemana(4);
            ConsultarNomeDoDiaDaSemana(7);
        }

        static void AdicionarDiaDaSemana(int dia, string nome)
        {
            //Início do trecho para alteração
            diasDaSemana.Add(dia, nome);
            //Fim do trecho para alteração
        }

        static void ConsultarNomeDoDiaDaSemana(int dia)
        {
            //Início do trecho para alteração
            Console.WriteLine(diasDaSemana[dia]);
            //Fim do trecho para alteração
        }

    }
}