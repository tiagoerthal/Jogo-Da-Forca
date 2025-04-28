namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PalavrasSecretas palavras = new PalavrasSecretas();
                Jogador jogador = new Jogador();

                jogador.palavraEscolhida = Jogo.RandomizarPalavra(palavras);
                jogador.letrasEncontradas = new char[jogador.palavraEscolhida.Length];

                for (int i = 0; i < jogador.letrasEncontradas.Length; i++)
                    jogador.letrasEncontradas[i] = '_';

                jogador.quantidadeErros = 0;
                jogador.jogadorAcertou = false;
                jogador.jogadorEnforcou = false;

                do
                {
                    jogador.dicaDaPalavra = string.Join("", jogador.letrasEncontradas);

                    Console.Clear();
                    Exibir.Cabecalho(jogador);

                    char chute = Console.ReadLine()![0];

                    bool letraFoiEncontrada = false;

                    for (int i = 0; i < jogador.palavraEscolhida.Length; i++)
                    {
                        if (char.ToUpper(jogador.palavraEscolhida[i]) == char.ToUpper(chute))
                        {
                            jogador.letrasEncontradas[i] = jogador.palavraEscolhida[i];
                            letraFoiEncontrada = true;
                        }
                    }

                    if (!letraFoiEncontrada)
                        jogador.quantidadeErros++;

                    jogador.dicaDaPalavra = string.Join("", jogador.letrasEncontradas);

                    jogador.jogadorAcertou = jogador.dicaDaPalavra == jogador.palavraEscolhida;
                    jogador.jogadorEnforcou = jogador.quantidadeErros > 5;

                } while (!jogador.jogadorAcertou && !jogador.jogadorEnforcou);

                Console.Clear();
                Exibir.MensagensFinais(jogador);

                string opcaoContinuar = Exibir.DesejaContinuar();
                if (opcaoContinuar != "S")
                    break;
            }
        }   
    }
}
