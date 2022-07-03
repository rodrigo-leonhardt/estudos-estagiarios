using System;

namespace ExemploMetodoExtensao
{

    public class MetodoExtensao1
    {

        public static void Executar()
        {
            string meuTexto = "Olá mundo!";

            meuTexto.ImprimirTextoNaTela();
        }
        
    }

    
    public static class MinhaExtensaoString
    {

        //Início do trecho para aleração
        public static void ImprimirTextoNaTela(this string texto)
        {
            Console.WriteLine(texto);
        }        
        //Fim do trecho para alteração

    }
    

}