namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                string palavrasecreta = "Melancia";

                char[] letrasEncontradas = new char[palavrasecreta.Length];

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
                    string dicaDaPalavra = string.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Jogo Da Forca");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Quantidade de erros: " + quantidadeErros);
                    Console.WriteLine("----------------------------------------");

                    Console.Write("Digite Uma Letra:  ");
                    char chute = Console.ReadLine()[0];  // char utiliza apenas 1 caractere que o usuaria digita

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavrasecreta.Length; contador++)
                    {
                        char letraAtual = palavrasecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada |= true;
                        }                      
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    dicaDaPalavra = string.Join(" ", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavrasecreta;
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta! Era: " + palavrasecreta);
                        Console.WriteLine("----------------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Que azar, tente novamente. A palavra era: " + palavrasecreta);
                        Console.WriteLine("----------------------------------------");
                    }
                } while (jogadorAcertou == false && jogadorEnforcou == false); // || = OU

                Console.ReadLine();
               
            }
        }
    }
}
