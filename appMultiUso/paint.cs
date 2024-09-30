using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMultiUso
{
    public partial class paint : Form
    {
        public paint()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BACK3_Click(object sender, EventArgs e)
        {
            Form backFormulario = new Form1();
            backFormulario.Show();
            this.Hide();
        }

        private void ayudaToolStripButton_Click(object sender, EventArgs e)
        {
            // Crear un nuevo ColorDialog
            ColorDialog colorDialog = new ColorDialog();

            // Configurar el ColorDialog (opcional)
            colorDialog.AllowFullOpen = true; 
            colorDialog.ShowHelp = true; 

            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
               
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    
                    g.Clear(colorDialog.Color);
                }

               
                pictureBox1.Image = bmp;

                
                Color selectedColor = colorDialog.Color;
            }
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();


            form1.BringToFront();


            this.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();


            form1.BringToFront();


            this.Close();
        }
    }
}
