using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I01_Eventos
{
    public partial class Form1 : Form
    {
        private Persona persona;

        public Form1()
        {
            InitializeComponent();
        }
        private static void NotificarCambio(string nombre)
        {
            MessageBox.Show(nombre);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona(txbNombre.Text , txbApellido.Text);
                //persona.delegadoString += NotificarCambio;
                btnCrear.Text = "Actualizar";
            }
            else
            {
                persona.notificarCambio += NotificarCambio;
                persona.Nombre = txbNombre.Text;
                persona.Apellido = txbApellido.Text;

            }

            lblNombreCompleto.Text = persona.Mostrar();

        }
    }
}
