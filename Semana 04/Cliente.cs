using System;

namespace ConceitosOOP
{
    public class Cliente
    {
        //Início do trecho para alteração
        readonly string _nome;
        readonly string _sobrenome;

        public Cliente(string nome, string sobrenome)
        {
            _nome = nome;
            _sobrenome = sobrenome;
        }

        public void Falar()
        {
            Console.WriteLine($"{_nome} diz qualquer coisa");
        }

        public void Falar(string texto)
        {
            Console.WriteLine($"{_nome} diz '{texto}'");
        }

        public string NomeCompleto()
        {
            return _nome +" "+ _sobrenome;
        }
        //Fim do trecho para alteração
    }
}