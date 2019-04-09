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

            //Converte de decimal para Hexa quando é inserido um valor no campo "Decimal".
            clsDecimalParaHexa novoHexa = new clsDecimalParaHexa();
            if (txtDecimal.Text == "")
            {
                novoHexa.numDecimal = 0;
            }
            else
            {
                novoHexa.numDecimal = Convert.ToInt32(txtDecimal.Text);
            }

            txtHexa.Text = novoHexa.converteParaHexa();

            //Converte de decimal para base 5 quando é inserido um valor no campo "Decimal".
            clsDecimalParaB5 novoB5 = new clsDecimalParaB5();
            if (txtDecimal.Text == "")
            {
                novoB5.numDecimal = 0;
            }
            else
            {
                novoB5.numDecimal = Convert.ToInt32(txtDecimal.Text);
            }

            txtBase5.Text = novoB5.converteParaB5();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = "";
            txtBinario.Text = "";
            txtOctal.Text = "";
            txtHexa.Text = "";
            txtBase5.Text = "";
        }

        private void txtBinario_TextChanged(object sender, EventArgs e)
        {
            //Converte de binário para decimal quando é inserido um valor no campo "Binário".
            clsBinarioParaDecimal novoDecimal = new clsBinarioParaDecimal();
            if (txtBinario.Text == "")
            {
                novoDecimal.numBinario = "";            }
            else
            {
                novoDecimal.numBinario = txtBinario.Text;
            }

            txtDecimal.Text = Convert.ToString(novoDecimal.converteParaDecimal());
        }

        private void txtHexa_TextChanged(object sender, EventArgs e)
        {

            //Converte de hexadecimal para decimal quando é inserido um valor no campo "Hexadecimal".

            clsHexaParaDecimal novoDecimal = new clsHexaParaDecimal();

             if (txtHexa.Text == "")
                {
                   novoDecimal.numHexadecimal = Convert.ToString(0);
             }
             else
             {
                   novoDecimal.numHexadecimal = Convert.ToString(txtHexa.Text);
             }

             txtDecimal.Text = Convert.ToString(novoDecimal.converteParaDecimal());

            
        }
    }
}
