using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class I01 : Form
    {
        public I01()
        {
            InitializeComponent();
        }

        private void AsignarHora(Label label)
        {
            int id = Task.CurrentId.Value;
            while (true)
            {
                label.Text = $"{DateTime.Now.ToString()}";
            }
        }

        private void RefrescarLabel(Label label)
        {
            if (InvokeRequired)
            {
                Action<Label> delegado = RefrescarLabel;

                //object[] objs = new object[] { barraProgreso, label, idHilo };
                
                Invoke(delegado , label);
            }
            else
            {
                AsignarHora(label);

            }
        }

        private void I01_Load(object sender, EventArgs e)
        {

            Task task = new Task(() => RefrescarLabel(label1));

            task.Start();

            

        }
    }
}
