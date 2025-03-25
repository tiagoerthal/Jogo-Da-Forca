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

                string dicaDaPalavra = string.Join(" ", letrasEncontradas);



                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Jogo Da Forca");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                Console.WriteLine("----------------------------------------");


                Console.Write("Digite Uma Letra:  ");
                char chute = Console.ReadLine()[0];  // char utiliza apenas 1 caractere que o usuaria digita

                Console.WriteLine(chute);

                Console.ReadLine();
            }
        }
    }
}
