using System;

namespace DiasDaSemana
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] diasDaSemana = {1, 2, 3, 4, 5, 6, 7, 8};
      
            Console.WriteLine("Dias da semana");
            Console.WriteLine();

            //Início do trecho para alteração
            for(var i=0; i < diasDaSemana.Length; i++)
            {
                var dia = diasDaSemana[i];
                var nomeDia = "";

                if (dia == 1)
                    nomeDia = "Domingo";
                else if (dia == 2)
                    nomeDia = "Segunda-feira";
                else if (dia == 3)
                    nomeDia = "Terça-feira";
                else if (dia == 4)
                    nomeDia = "Quarta-feira";
                else if (dia == 5)
                    nomeDia = "Quinta-feira";
                else if (dia == 6)
                    nomeDia = "Sexta-feira";
                else if (dia == 7)
                    nomeDia = "Sábado";
                else
                    nomeDia = "Inválido";

                Console.WriteLine($"Dia {dia} é {nomeDia}");
            }
            
            //Fim do trecho para alteração

        }
    }
}