using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsHexaParaDecimal
    {
        public string numHexadecimal { get; set; }
        public int numDecimal { get; set; }

        public int converteParaDecimal()
        {
            return Convert.ToInt32(numHexadecimal, 16);

        }
    }
}
