using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsDecimalParaBinario
    {
        public string numBinario { get; set; }
        public int numDecimal { get; set; }

        public string converteParaBinario()
        {
            int resto;
            string resultado = string.Empty;
            
            while(numDecimal > 0)
            {
                resto = numDecimal % 2;
                resultado += Convert.ToString(resto);
                numDecimal /= 2;
            }

            numBinario = new string(resultado.Reverse().ToArray());

            return numBinario;
        }
    }
}
