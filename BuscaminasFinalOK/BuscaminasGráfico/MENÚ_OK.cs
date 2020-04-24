using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buscaminas;

namespace BuscaminasGráfico
{
    public partial class MENÚ_OK : Form
    {
        public MENÚ_OK()
        {
            InitializeComponent();
        }

        private void Buscaminas_Load(object sender, EventArgs e)
        {
            //this.nMinas.Maximun = this.nAltoValue * this.nAncho.Value - 5;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickFacil(object sender, EventArgs e)
        {
            NivelOK nivel = new NivelOK();
            nivel.Show();
            this.Hide();
            nivel.game = new Game<Celda> (8, 8, 10);
        }
        private void Medio_Click(object sender, EventArgs e)
        {

        }

        private void Difícil_Click(object sender, EventArgs e)
        {

        }
        private void ClickPersonalizado(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ANCHO_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void Personalizado(object sender, EventArgs e)
        {

        }

        private void Personalizado(object sender, PaintEventArgs e)
        {

        }
    }
}
