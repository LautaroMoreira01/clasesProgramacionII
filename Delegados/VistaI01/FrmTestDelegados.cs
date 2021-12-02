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
    public partial class FrmTestDelegados : Form
    {
        public delegate void DelegadoActualizarLabel(string str);
        DelegadoActualizarLabel delegadoActualizarLabel;

        public FrmTestDelegados(DelegadoActualizarLabel delegadoActualizarLabel)
        {
            InitializeComponent();
            this.delegadoActualizarLabel = delegadoActualizarLabel;

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            delegadoActualizarLabel.Invoke(this.txtNombre.Text);
        }

    }
}
