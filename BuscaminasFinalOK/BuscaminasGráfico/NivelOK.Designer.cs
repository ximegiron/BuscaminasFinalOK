namespace BuscaminasGráfico
{
    partial class NivelOK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMinas = new System.Windows.Forms.Label();
            this.LabelTiempo = new System.Windows.Forms.Label();
            this.tbCeldas = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbCeldas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.84536F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbMinas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelTiempo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 115);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbMinas
            // 
            this.lbMinas.AutoSize = true;
            this.lbMinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMinas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinas.Location = new System.Drawing.Point(3, 0);
            this.lbMinas.Name = "lbMinas";
            this.lbMinas.Size = new System.Drawing.Size(376, 57);
            this.lbMinas.TabIndex = 0;
            this.lbMinas.Text = "MINAS RESTANTES";
            this.lbMinas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMinas.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelTiempo
            // 
            this.LabelTiempo.AutoSize = true;
            this.LabelTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTiempo.Location = new System.Drawing.Point(385, 0);
            this.LabelTiempo.Name = "LabelTiempo";
            this.LabelTiempo.Size = new System.Drawing.Size(376, 57);
            this.LabelTiempo.TabIndex = 1;
            this.LabelTiempo.Text = "TIEMPO";
            this.LabelTiempo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelTiempo.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCeldas
            // 
            this.tbCeldas.ColumnCount = 1;
            this.tbCeldas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbCeldas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbCeldas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCeldas.Location = new System.Drawing.Point(3, 124);
            this.tbCeldas.Name = "tbCeldas";
            this.tbCeldas.RowCount = 1;
            this.tbCeldas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbCeldas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbCeldas.Size = new System.Drawing.Size(764, 358);
            this.tbCeldas.TabIndex = 1;
            this.tbCeldas.Paint += new System.Windows.Forms.PaintEventHandler(this.tbCeldas_Paint);
            // 
            // NivelOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NivelOK";
            this.Text = "NivelOK";
            this.Load += new System.EventHandler(this.NivelOK_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbMinas;
        private System.Windows.Forms.Label LabelTiempo;
        private System.Windows.Forms.TableLayoutPanel tbCeldas;
    }
}