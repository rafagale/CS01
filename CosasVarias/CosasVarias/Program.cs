using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace CosasVarias
{
    public class Leer
    {
        static void Main(string[] args)
        {

           

        }//Main

        public static void Hablar(string frase)
        {
            SpeechSynthesizer hablar = new SpeechSynthesizer();
        pedir:
            try
            {
                Console.WriteLine("Introduce un numero");
                frase = Console.ReadLine();
            }
            catch (Exception)
            {
                goto pedir;
            }
        }//Hablar

        public static int pedirEntero(string frase)
        {
            int numero = 0;
        pedirEntero:
            try
            {
                Console.WriteLine(frase);
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                goto pedirEntero;
            }
            return numero;

        }//PedirEntero

    }//Class

}//namespace
