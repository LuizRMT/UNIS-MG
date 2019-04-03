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
        public int numOctal { get; set; }

        /*public string converteParaOctal()
        {
            int expoente = 0, numMax = 0;
            
            while (numMax <= numDecimal)
            {
                numMax = Convert.ToUInt32(Math.Pow(8, expoente));

                expoente++;
            }

            while (expoente >= 0)
            {
                numOctal += numDecimal / Convert.ToUInt32(Math.Pow(8, expoente));

                expoente--;
            }

            return Convert.ToString(numOctal);
        }*/
    }
}
