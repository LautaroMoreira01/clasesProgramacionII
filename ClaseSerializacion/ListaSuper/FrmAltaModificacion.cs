using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSuper
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto{ get { return txtObjeto.Text; }}
        public FrmAltaModificacion(string titulo , string textoObjeto, string textoBotonConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = textoObjeto;
            btnConfirmar.Text = textoBotonConfirmar;
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtObjeto.Text))
            {
                DialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                MessageBox.Show("ERROR, el campo no puede estar vacio.", "Error.", MessageBoxButtons.OKCancel , MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void FrmAltaModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnCancelar_Click(sender , e);
        }

    }
}
