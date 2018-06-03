using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivos
{
    class Program
    {
        static void Main(string[] args)
        {

        }//main

        public static int Minimo(int[] numeros, int minimoInf, int minimoSup)
        {
            if (minimoInf == minimoSup)
                return numeros[minimoSup];
            if (numeros[minimoInf] > numeros[minimoSup])
                return Minimo(numeros, minimoInf + 1, minimoSup);
            else return Minimo(numeros, minimoInf, minimoSup - 1);
        }//Minimo


        public static int sumarDigitos(int num)
        {
            if (num == 0)
            {
                return num;
            }
            else
            {
                return num % 10 + sumarDigitos(num / 10);
            }
        }//sumarDigitos

    }//Class

}//namespace
