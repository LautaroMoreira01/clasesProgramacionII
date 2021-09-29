using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private bool ValidateEmptyTextbox(string strNumero)
        {
            bool rta = true;

            if (strNumero == null || strNumero  == string.Empty)
            {
                rta = false;
                throw new ParametrsoVaciosException($"el parametro  no fueron cargados.");
            }
            return rta;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            float result;
            try
            {
                ValidateEmptyTextbox(this.tbKilometros.Text);
                ValidateEmptyTextbox(this.tbLitros.Text);
                try
                {
                    numero1 = int.Parse(this.tbKilometros.Text);
                    numero2 = int.Parse(this.tbLitros.Text);
                    
                    result = Calculador.Calcular(numero1, numero2);

                    richTextBox1.AppendText(result.ToString() + "\n");
                }
                catch (FormatException)
                {
                    throw;
                }
                catch (DivideByZeroException)
                {
                    throw;
                }
            }
            catch (ParametrsoVaciosException parametrosVaciosEx)
            {
                MessageBox.Show(parametrosVaciosEx.Message);
            }
            catch (FormatException errorFormatoEx)
            {
                MessageBox.Show(errorFormatoEx.Message);
            }
            catch (DivideByZeroException divideByZeroEx)
            {
                MessageBox.Show(divideByZeroEx.Message);

            }
        }
    }
}
