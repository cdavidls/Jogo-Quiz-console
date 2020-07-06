using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            int acertos = 0;
            int erros = 0;

            Console.WriteLine("### PRIMEIRA PERGUNTA ###");
            Console.WriteLine("Por que utilizamos variáveis na programação?");
            Console.WriteLine("");
            Console.WriteLine("[A] Para escrever na tela");
            Console.WriteLine("[B] Para guardar dados temporários na memória");
            Console.WriteLine("[C] Para guardar dados permanentes no HD");
            Console.WriteLine("");
            Console.Write("Informe a resposta: ");
            resposta = Console.ReadLine();

            switch (resposta.ToUpper())
            {
                case "A":
                    erros++;
                    break;
                case "B":
                    acertos++;
                    break;
                case "C":
                    erros++;
                    break;
                default:
                    Console.WriteLine("Alternativa Inválida!");
                    erros++;
                    break;
            }

            

            Console.Clear();

            Console.WriteLine("### SEGUNDA PERGUNTA ###");
            Console.WriteLine("O Visual Studio é uma:");
            Console.WriteLine("");
            Console.WriteLine("[A] Linguagem de Programação");
            Console.WriteLine("[B] Programa para desenvolver outros programas");
            Console.WriteLine("[C] Para acrescentar +1");
            Console.WriteLine("");
            Console.Write("Informe a resposta: ");
            resposta = Console.ReadLine();

            if (resposta.ToUpper() == "B")
                acertos++;
            else
                erros++;

            Console.Clear();

            Console.WriteLine("### TERCEIRA PERGUNTA ###");
            Console.WriteLine("Por que utilizamos IF na programação?");
            Console.WriteLine("");
            Console.WriteLine("[A] Para tomar decisões baseados em uma condição");
            Console.WriteLine("[B] Para escrever na tela");
            Console.WriteLine("[C] Para guardar dados temporários na memória ");
            Console.WriteLine("");
            Console.Write("Informe a resposta: ");
            resposta = Console.ReadLine();

            if (resposta.ToUpper() == "A")
                acertos++;
            else
                erros++;

            Console.Clear();

            Console.WriteLine("### QUARTA PERGUNTA ###");
            Console.WriteLine("O C# é:");
            Console.WriteLine("");
            Console.WriteLine("[A] Linguagem de Programação");
            Console.WriteLine("[B] Programa para desenvolver outros programas");
            Console.WriteLine("[C] Para acrescentar +1");
            Console.WriteLine("");
            Console.Write("Informe a resposta: ");
            resposta = Console.ReadLine();

            if (resposta.ToUpper() == "A")
                acertos++;
            else
                erros++;

            Console.Clear();

            Console.WriteLine("### QUINTA PERGUNTA ###");
            Console.WriteLine("Por que utilizamos auto incremento na programação?");
            Console.WriteLine("");
            Console.WriteLine("[A] Para tomar decisões baseados em uma condição");
            Console.WriteLine("[B] Para remover +1");
            Console.WriteLine("[C] Para acrescentar +1");
            Console.WriteLine("");
            Console.Write("Informe a resposta: ");
            resposta = Console.ReadLine();

            if (resposta.ToUpper() == "C")
                acertos++;
            else
                erros++;

            Console.Clear();

            Console.WriteLine("### SEXTA PERGUNTA ###");
            Console.WriteLine("O Console.WriteLine é um comando que:");
            Console.WriteLine("");
            Console.WriteLine("[A] Lê o conteúdo e uma variável ");
            Console.WriteLine("[B] Para escrever na tela");
            Console.WriteLine("[C] Para guardar dados temporários na memória ");
            Console.WriteLine("");
            Console.Write("Informe a resposta: ");
            resposta = Console.ReadLine();

            if (resposta.ToUpper() == "B")
                acertos++;
            else
                erros++;

            Console.Clear();


            Console.WriteLine("Quantidade de acertos: " + acertos);
            Console.WriteLine("Quantidade de erros: " + erros);

            Console.ReadKey();

        }
    }
}
