using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsB5ParaDecimal
    {
        public int numB5 { get; set; }
        public int numDecimal { get; set; }

        public string converteParaDecimal()
        {
            int expoente = 0, numero;

            for (int i = 1; numB5 > 0; i++)
            {
                numero = numB5 % 10;
                numDecimal += numero * (int)Math.Pow(5, expoente);

                expoente++;
                numB5 /= 10;
            }

            return Convert.ToString(numDecimal);
        }
    }
}
