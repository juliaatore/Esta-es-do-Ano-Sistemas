using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estações_do_ano
{
    public partial class Frm_Estacoes : Form
    {
        public Frm_Estacoes()
        {
            InitializeComponent();
        }

        private void Rad_Primavera_CheckedChanged_1(object sender, EventArgs e)
        {
            Pic_Imagem.Image = Properties.Resources.Primavera;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rad_Primavera_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Imagem.Image = Properties.Resources.Primavera;
            textBox1.Text = "Primavera: 22/23 de Setembro a 22 de Desembro";


        }

        private void Rad_Verao_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Imagem.Image = Properties.Resources.Verao;
            textBox1.Text = "Verão: 22 de Desembro a 20 de Março";
        }

        private void Rad_Outono_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Imagem.Image = Properties.Resources.Outono;
            textBox1.Text = "Outono: 20 de Março a 21 Junho";
        }

        private void Rad_Inverno_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Imagem.Image = Properties.Resources.Inverno;
            textBox1.Text = "Inverno: 21 de Junho a 23 de Setembro";
        }
    }
}
