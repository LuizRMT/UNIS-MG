using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsDecimalParaOctal
    {
        public int numDecimal { get; set; }
        public string numOctal { get; set; }

        public string converteParaOctal()
        {
            int expoente = 0, numMax = 0, resultado = 0;
            
            while (numMax < numDecimal)
            {
                numMax = (int)Math.Pow(8, expoente);

                expoente++;

               if(numMax > numDecimal)
                {
                    expoente--;
                }
             
            }

            expoente--;

            while (expoente >= 0)
            {
                resultado = Convert.ToInt32(numDecimal / (int)Math.Pow(8, expoente));              

                if(resultado >= 10)
                {
                    resultado /= 10;
                }
                
                numDecimal -= resultado * (int)Math.Pow(8, expoente);

                numOctal += Convert.ToString(resultado);

                expoente--;

            }

            return numOctal;
        }
    }
}
