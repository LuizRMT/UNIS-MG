using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadoraDeProgramador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            //Converte de decimal para binário quando é inserido valor no campo "Decimal".
            clsDecimalParaBinario novoBinario = new clsDecimalParaBinario();
            
            if(txtDecimal.Text == "")
            {
                novoBinario.numDecimal = 0;
            }
            else
            {
                novoBinario.numDecimal = Convert.ToInt32(txtDecimal.Text);
            }

            txtBinario.Text = novoBinario.converteParaBinario();

            //Converte de decimal para octal quando é inserido valor no campo "Decimal".
            clsDecimalParaOctal novoOctal = new clsDecimalParaOctal();

            if (txtDecimal.Text == "")
            {
                novoOctal.numDecimal = 0;
            }
            else
            {
                novoOctal.numDecimal = Convert.ToInt32(txtDecimal.Text);
            }

            txtOctal.Text = novoOctal.converteParaOctal();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = "";
            txtBinario.Text = "";
            txtOctal.Text = "";
            txtHexa.Text = "";
            txtBase5.Text = "";
        }
    }
}
