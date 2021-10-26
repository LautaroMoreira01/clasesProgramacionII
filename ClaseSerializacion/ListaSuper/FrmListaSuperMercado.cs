﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListaSuper
{
    public partial class FrmListaSuperMercado : Form
    {
        private string path = "";

        private List<string> listaCompras;
        public FrmListaSuperMercado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion( "Agregar objeto.", "" , "Agregar.");
            frmAltaModificacion.ShowDialog();
        
            if(frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                listaCompras.Add(frmAltaModificacion.Objeto);
                ActualizarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (VerificarSeleccionDeObjeto("Se debe seleccionar un elemento para poder eliminar.", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                listaCompras.RemoveAt(lstObjetos.SelectedIndex);
                ActualizarLista();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarSeleccionDeObjeto("Se debe seleccionar un elemento para poder modificar.", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar.", lstObjetos.SelectedItem.ToString() , "Agregar.");
                    frmAltaModificacion.ShowDialog();
                    listaCompras.RemoveAt(lstObjetos.SelectedIndex);
                    listaCompras.Add(frmAltaModificacion.Objeto);
                    ActualizarLista();
                }

            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        private bool VerificarSeleccionDeObjeto(string tittle , string message , MessageBoxButtons buttons , MessageBoxIcon icon)
        {
            bool rta = false;
            if (lstObjetos.SelectedItem != null)
            {
                rta = true;
            }
            else
            {
                MessageBox.Show(message, tittle, buttons, icon);
            }
            return rta;
        }

        private void FrmListaSuperMercado_Load(object sender, EventArgs e)
        {
            listaCompras = new List<string>();
            
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            
            Path.Combine(path, "listaSupermercado.xml");
            
            if (File.Exists(path))
            {
                listaCompras = DeserializarDeXml<List<string>>(path);
                foreach(string item in listaCompras)
                {
                    listaCompras.Add(item);
                }
            }
        }

        private T DeserializarDeXml<T>(string path) 
            where T : class
        {
            List<string> list = new List<string>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T objeto = xmlSerializer.Deserialize(streamReader) as T;
                return objeto;
            }
        }
        private void ActualizarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaCompras;
        }

    }
}
