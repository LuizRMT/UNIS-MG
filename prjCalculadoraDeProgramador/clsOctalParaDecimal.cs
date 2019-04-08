using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsOctalParaDecimal
    {
        public int numOctal { get; set; }
        public int numDecimal { get; set; }

        public string converteParaDecimal()
        {
            int expoente = 0, numero;

            for (int i=1; numOctal>0; i++)
            {
                numero = numOctal % 10;
                numDecimal += numero * (int)Math.Pow(8, expoente);

                expoente++;
                numOctal /= 10;
            }

            return Convert.ToString(numDecimal);
        }
    }
}
