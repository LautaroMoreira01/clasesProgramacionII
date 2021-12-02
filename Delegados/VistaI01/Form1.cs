using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaI01
{
    
    public partial class Form1 : Form
    {
        FrmMostrar frmMostrar ;
        FrmTestDelegados frmTestDelegados;
        
        public Form1()
        {
            InitializeComponent();


        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmMostrar.MdiParent = this;
            frmTestDelegados.MdiParent = this;
            mostrarToolStripMenuItem.Enabled = false;
        }
    }
}
