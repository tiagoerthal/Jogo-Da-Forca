using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
   public class Exibir
    {
        public static void Cabecalho(Jogador jogador)
        {
            string cabecaBoneco = jogador.quantidadeErros >= 1 ? " O " : " ";
            string corpoCima = jogador.quantidadeErros >= 2 ? "x" : " ";
            string corpoBaixo = jogador.quantidadeErros >= 3 ? " x " : " ";
            string bracoEsquerdo = jogador.quantidadeErros >= 4 ? "/" : " ";
            string bracoDireito = jogador.quantidadeErros >= 5 ? @"\" : " ";
            string pernas = jogador.quantidadeErros >= 6 ? "/ \\" : " ";

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jogo Da Forca");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, corpoCima, bracoDireito);
            Console.WriteLine(" |        {0}       ", corpoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Palavra secreta: " + jogador.dicaDaPalavra);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Quantidade de erros: " + jogador.quantidadeErros);
            Console.WriteLine("----------------------------------------");
            Console.Write("Digite uma letra: ");
        }

        public static void MensagensFinais(Jogador jogador)
        {
            if (jogador.jogadorAcertou)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Parabéns! Você acertou a palavra: " + jogador.palavraEscolhida);
                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Que pena! A palavra era: " + jogador.palavraEscolhida);
                Console.WriteLine("----------------------------------------");
            }
        }

        public static string DesejaContinuar()
        {
            string opcaoContinuar = "";

            do
            {
                Console.Write("Deseja jogar novamente? (S/N): ");
                opcaoContinuar = Console.ReadLine()!.Trim().ToUpper();
            } while (opcaoContinuar != "S" && opcaoContinuar != "N");

            return opcaoContinuar;
        }
    }
}
