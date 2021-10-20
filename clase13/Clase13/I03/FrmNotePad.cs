using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I03
{
    public partial class FrmNotePad : Form
    {
        private OpenFileDialog openFileDialog1;
        private string path;

        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArchivo();

        }

        private string ReadFile(string path)
        {
            string rta = "";
            if (File.Exists(path))
            {
                rta =  File.ReadAllText(path);
            }
            return rta;
        }
        private void AbrirArchivo()
        {
            
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            openFileDialog1.ShowDialog();

            path = openFileDialog1.FileName;
            
            rtbText.Text = ReadFile(path);
        }
        private void WriteFile(string path)
        {
            if (path != "")
            {
                File.WriteAllText(path, rtbText.Text);
            }
        }
        private void SaveFile()
        {
            if (path != "" && File.Exists(path))
            {
                File.WriteAllText(path, rtbText.Text);
            }
            else
            {
                SaveFileAs();
            }
        }
        private void SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Save file as..."
            };

            saveFileDialog.ShowDialog();

            string savePath = saveFileDialog.FileName;

            if(savePath == "")
            {
                MessageBox.Show("No se guardo el archivo por nombre invalido.", "Alert!!!" , MessageBoxButtons.OKCancel , MessageBoxIcon.Error);

            }
            
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            string text = rtbText.Text.Trim();
            lblCantCaracteres.Text = text.Length.ToString();
        }
    }

}
