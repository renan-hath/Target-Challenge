using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetChallenge.Desafio01
{
    public class Desafio01
    {
        public static int Somar(int i, int k, int soma)
        {
            while (k < i)
            {
                k++;
                soma += k;
            }

            return soma;
        }
    }
}