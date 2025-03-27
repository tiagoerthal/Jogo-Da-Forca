namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                string[] palavras =
                {
                    "BANANA",
                    "UVA",
                    "PITAYA",
                    "LARANJA",
                    "MELANCIA",
                    "MACA",
                    "KIWI",
                };                           

                Random random = new Random();

                int indiceEscolhido = random.Next(palavras.Length);

                string palavraEscolhida = palavras[indiceEscolhido];

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    // acessar o array no indice 0
                    letrasEncontradas[caractere] = '_';

                }                

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = true;

                do
                {
                    string cabecaBoneco = quantidadeErros >= 1 ? " O " : " ";
                    string corpoCima = quantidadeErros >= 2 ? "x" : " ";
                    string corpoBaixo = quantidadeErros >= 3 ? " x " : " ";
                    string bracoEsquerdo = quantidadeErros >= 4 ? "/" : " ";
                    string bracoDireito = quantidadeErros >= 5 ? @"\" : " ";
                    string pernas = quantidadeErros >= 6 ? "/ \\" : " ";

                    string dicaDaPalavra = string.Join("", letrasEncontradas);

                    Console.Clear();
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
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Quantidade de erros: " + quantidadeErros);
                    Console.WriteLine("----------------------------------------");

                    Console.Write("Digite Uma Letra:  ");
                    char chute = Console.ReadLine()[0];

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraEscolhida.Length; contador++)
                    {
                        char letraAtual = palavraEscolhida[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada |= true;
                        }                      
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    dicaDaPalavra = string.Join(" ", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraEscolhida;
                    jogadorEnforcou = quantidadeErros > 5;                  

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta! Era: " + palavraEscolhida);
                        Console.WriteLine("----------------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Que azar, tente novamente. A palavra era: " + palavraEscolhida);
                        Console.WriteLine("----------------------------------------");
                    }

                } while (jogadorAcertou == false && jogadorEnforcou == false); // && = OU

                Console.Write("Deseja continuar? (S/N): ");

                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();               
            }
        }
    }
}
