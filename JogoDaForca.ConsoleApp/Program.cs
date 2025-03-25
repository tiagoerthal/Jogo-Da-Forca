namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jogo Da Forca");
            Console.WriteLine("----------------------------------------");




            Console.Write("Digite Uma Letra:  ");
            char chute = Console.ReadLine()[0];  // char utiliza apenas 1 caractere que o usuaria digita

            Console.WriteLine(chute);

            Console.ReadLine();
        }
    }
}
