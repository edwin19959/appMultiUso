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

namespace appMultiUso
{
    public partial class editor : Form
    {

        string Archivo;
        public editor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form backFormulario = new Form1();
            backFormulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            
            {
                Archivo = openFileDialog.FileName;

                using (StreamReader sr = new StreamReader(Archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }

            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();

          
            form1.BringToFront();

            
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            // Si ya existe una ruta, la usamos como ruta inicial
            if (Archivo != null)
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(Archivo);
                saveFileDialog.FileName = Path.GetFileName(Archivo);
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Archivo = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter writer = new StreamWriter(Archivo))
                    {
                        writer.Write(richTextBox1.Text);
                    }
                    MessageBox.Show("Archivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Archivo = null;


        }
    }
}
