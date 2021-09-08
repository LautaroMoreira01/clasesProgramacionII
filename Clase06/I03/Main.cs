using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I03
{
    public partial class Main : Form
    {
        public Dictionary <string , int > diccionario = new Dictionary<string, int>(); 

        public Main()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           


                
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> palabras = new List<string>();

            char[] caracteres = new char[] { ' ', '.', ',', '-', ':' };
            string[] palabrasSeparadas = rtbPalabras.Text.Split(caracteres);

            palabras.AddRange(palabrasSeparadas);

            foreach (string item in palabrasSeparadas)
            {
                if(!(diccionario.ContainsKey(item)))
                {
                    diccionario.Add(item, 1);
                }
                else
                {
                    diccionario[item] += 1 ;
                }

            }
        }

        private Dictionary<string , int > TopTresPalabras(Dictionary<string , int> diccionario)
        {
            Dictionary<string, int> rta = new Dictionary<string, int>(); 

            

        }
        private Dictionary<string , int > SortDictionary(Dictionary<string , int> diccionario)
        {
            Dictionary<string, int> rta = new Dictionary<string, int>(); 
            Dictionary<string, int> aux = new Dictionary<string, int>();

            SortDictionary<string, int> diccionarioOrdenado = new SortDictionary<string, int>();

            foreach(string item in diccionario.Keys)
            {
                if(diccionario[item] > diccionario[item + 1])
                {
                    aux[item] =  ;
                }
            }

        }
    }
}
