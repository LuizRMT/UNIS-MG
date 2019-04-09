using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsDecimalParaB5
    {
        public int numDecimal { get; set; }
        public string numB5 { get; set; }

        public string converteParaB5()
        {
            int quociente = 0;
            string resto = string.Empty;

            do
            {
                quociente = numDecimal / 5;
                resto += Convert.ToString(numDecimal % 5);

                numDecimal /= 5;
            } while (quociente > 5);
                        
            numB5 = Convert.ToString(quociente) + new string(resto.Reverse().ToArray());

            return numB5;
        }
    }
}
