using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContanum_Click(object sender, EventArgs e)
        {
            int posição = 0;
            int contaNum = 0;  
            while(posição < rchtxtFrase.Text.Length)
             {
                if (char.IsNumber(rchtxtFrase.Text[posição]))
                    {
                      contaNum++;           
                    }

                posição++;  
             }
            MessageBox.Show($"o texto tem {contaNum} numeros");
        }

        private void btnCaracterBranco_Click(object sender, EventArgs e)
        {
            for(var i=0;i < rchtxtFrase.Text.Length; i++) 
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i])) 
                {
                    MessageBox.Show($"O primeiro caracter branco esta na posição {i + 1}");
                    break;
                }

                
            }
           
        }

        private void btnContaLetra_Click(object sender, EventArgs e)
        {
            int contaLetra = 0;
            foreach (var c in rchtxtFrase.Text) 
            {
                if (char.IsLetter(c)) 
                {
                    contaLetra++;
                }
        
            }
            MessageBox.Show($"o texto contem {contaLetra} letras");
        }

    }
}
