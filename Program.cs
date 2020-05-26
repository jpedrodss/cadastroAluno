using System;

namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno joao = new Aluno();
            Console.WriteLine("Qual seu nome?");
            joao.nome = Console.ReadLine();
            Console.WriteLine("\nQual sua idade?");
            joao.idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite seu RG.");
            joao.rg = Console.ReadLine();
            Console.WriteLine("\nDigite seu curso.");
            joao.curso = Console.ReadLine();
            Console.WriteLine("\nVocê é Bolsista?");
            joao.bolsista = joao.TraduzConsole(Console.ReadLine());
            Console.WriteLine("\nQual o percentual da sua bolsa?");
            joao.percentual = float.Parse(Console.ReadLine());
            Console.WriteLine("\nQual sua média final?");
            joao.mediaFinal = float.Parse(Console.ReadLine());
            Console.WriteLine("\nQual valor da sua mensalidade?");
            joao.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSua média final foi: "+joao.mediaFinal);       
            Console.WriteLine("\nSua mensalidade custa: "+joao.valorMensalidade);           

        }
    }
}
