using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    public class Jogo
    {
        public static string RandomizarPalavra(PalavrasSecretas palavras)
        {
            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Palavras.Length);
            return palavras.Palavras[indiceEscolhido];

           
        } 
       
    }
}
