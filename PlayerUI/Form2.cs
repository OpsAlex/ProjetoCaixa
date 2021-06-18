using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PlayerUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnAbrir_Click(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        public void btnCarregar_Click(object sender, EventArgs e)
        {


        }

        private void listPlaylist_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void listPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        public void pPlayer (object sender, EventArgs e)
        {

        }

        public void pStop (object sender, EventArgs e)
        {

        }

        public void btnPlaying_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
                if (textBox1.Text == listPlaylist.Text)
                {
                    MessageBox.Show(listPlaylist.Text);
                }
            */
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                        /*
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    var nome = textBox1.Text.Trim();
                    if (nome == listPlaylist.Text.Trim())
                    {
                        MessageBox.Show(listPlaylist.Text);
                    }
                    else
                    {
                        MessageBox.Show("não deu certo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe o Nome da musica...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }
    }
}
