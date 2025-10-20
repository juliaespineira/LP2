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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu copiar");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu colar");
        }

        private void exercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else 
            {
                frmExercicio2 objFrm2 = new frmExercicio2();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show(); 
            }
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frmExercicio3 objFrm3 = new frmExercicio3();
                objFrm3.MdiParent = this;
                objFrm3.WindowState = FormWindowState.Maximized;
                objFrm3.Show();
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frmExercicio4 objFrm4 = new frmExercicio4();
                objFrm4.MdiParent = this;
                objFrm4.WindowState = FormWindowState.Maximized;
                objFrm4.Show();
            }
        }
    }
}
