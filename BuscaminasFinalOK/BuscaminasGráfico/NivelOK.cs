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
using BuscaminasGráfico.Properties;

namespace BuscaminasGráfico
{        
    public partial class NivelOK : Form
    {
        public Game <Celda> game;
        private object Game;

        public NivelOK()
        {
            InitializeComponent();
        }

        private void NivelOK_Load(object sender, EventArgs e)
        {
            if (game != null)
            {
                this.setStats();
            }
        }
        private void setStats()
        {
            this.lbMinas.Text = game.FlagsCount + "";
        }

        public void CreateGrid()
        {
            for (int i = 0; i < this.game.width; i++)
            {
                this.tbCeldas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            for (int j = 0; j < this.game.height; j++)
            {
                this.tbCeldas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            }
            for (int i = 0; i < this.game.width; i++)
            {
                for (int j = 0; j < this.game.height; j++) this.tbCeldas.Controls.Add(new Button(), i, j);
                {
                    int j = 0;
                    this.tbCeldas.Controls.Add(new CellButton(), i, j);
                }
            }
        }

        private void Nivel_Load(object sender, EventArgs e)
        {
            if (Game != null)
            {
                this.setStats();
                this.CreateGrid();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbCeldas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


