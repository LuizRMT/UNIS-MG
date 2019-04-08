using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsDecimalParaHexa
    {
        public int numDecimal { get; set; }
        public string numHexa { get; set; }

        public string converteParaHexa()
        {
            int expoente = 1, numMax = 0, resultado = 0;
            string letra = string.Empty;

            while (numMax < numDecimal)
            {
                numMax = (int)Math.Pow(16, expoente);

                expoente++;

                if (numMax > numDecimal)
                {
                    expoente--;
                }

            }

            expoente--;

            while (expoente >= 0)
            {
                resultado = Convert.ToInt32(numDecimal / (int)Math.Pow(16, expoente));

                if (resultado >= 10)
                {
                    switch (resultado)
                    {
                        case 10:
                            letra = "A";
                            break;
                        case 11:
                            letra = "B";
                            break;
                        case 12:
                            letra = "C";
                            break;
                        case 13:
                            letra = "D";
                            break;
                        case 14:
                            letra = "E";
                            break;
                        case 15:
                            letra = "F";
                            break;
                    }

                    numHexa += letra;
                }
                else
                {
                    numHexa += Convert.ToString(resultado);
                }

                numDecimal -= resultado * (int)Math.Pow(16, expoente);

                expoente--;

            }

            return numHexa;
        }
    }
}
