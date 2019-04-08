using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadoraDeProgramador
{
    class clsBinarioParaDecimal
    {
        public int numDecimal { get; set; }
        public string numBinario { get; set; }

        public int converteParaDecimal()
        {
            
            return Convert.ToInt32(numBinario, 2);
        }
    }
}
