namespace BuscaminasGráfico
{
    partial class MENÚ_OK
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Fácil = new System.Windows.Forms.Button();
            this.Medio = new System.Windows.Forms.Button();
            this.Difícil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NUMMINAS = new System.Windows.Forms.NumericUpDown();
            this.ALTO = new System.Windows.Forms.NumericUpDown();
            this.ANCHO = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMMINAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANCHO)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Fácil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Medio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Difícil, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 468);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Fácil
            // 
            this.Fácil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Fácil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fácil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fácil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Fácil.Location = new System.Drawing.Point(3, 3);
            this.Fácil.Name = "Fácil";
            this.Fácil.Size = new System.Drawing.Size(543, 111);
            this.Fácil.TabIndex = 0;
            this.Fácil.Text = "FÁCIL";
            this.Fácil.UseVisualStyleBackColor = false;
            this.Fácil.Click += new System.EventHandler(this.ClickFacil);
            // 
            // Medio
            // 
            this.Medio.BackColor = System.Drawing.Color.Lime;
            this.Medio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Medio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medio.ForeColor = System.Drawing.Color.Green;
            this.Medio.Location = new System.Drawing.Point(3, 120);
            this.Medio.Name = "Medio";
            this.Medio.Size = new System.Drawing.Size(543, 111);
            this.Medio.TabIndex = 1;
            this.Medio.Text = "MEDIO";
            this.Medio.UseVisualStyleBackColor = false;
            this.Medio.Click += new System.EventHandler(this.Medio_Click);
            // 
            // Difícil
            // 
            this.Difícil.BackColor = System.Drawing.Color.Red;
            this.Difícil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Difícil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difícil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Difícil.Location = new System.Drawing.Point(3, 237);
            this.Difícil.Name = "Difícil";
            this.Difícil.Size = new System.Drawing.Size(543, 111);
            this.Difícil.TabIndex = 2;
            this.Difícil.Text = "DIFÍCIL";
            this.Difícil.UseVisualStyleBackColor = false;
            this.Difícil.Click += new System.EventHandler(this.Difícil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(327, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "PERSONALIZADO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Personalizado);
            // 
            // NUMMINAS
            // 
            this.NUMMINAS.BackColor = System.Drawing.Color.Thistle;
            this.NUMMINAS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMMINAS.ForeColor = System.Drawing.Color.DarkViolet;
            this.NUMMINAS.Location = new System.Drawing.Point(219, 48);
            this.NUMMINAS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUMMINAS.Name = "NUMMINAS";
            this.NUMMINAS.Size = new System.Drawing.Size(72, 32);
            this.NUMMINAS.TabIndex = 6;
            this.NUMMINAS.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUMMINAS.ValueChanged += new System.EventHandler(this.ANCHO_ValueChanged);
            // 
            // ALTO
            // 
            this.ALTO.BackColor = System.Drawing.Color.Thistle;
            this.ALTO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALTO.ForeColor = System.Drawing.Color.DarkViolet;
            this.ALTO.Location = new System.Drawing.Point(111, 48);
            this.ALTO.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ALTO.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ALTO.Name = "ALTO";
            this.ALTO.Size = new System.Drawing.Size(56, 32);
            this.ALTO.TabIndex = 5;
            this.ALTO.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ALTO.ValueChanged += new System.EventHandler(this.ANCHO_ValueChanged);
            // 
            // ANCHO
            // 
            this.ANCHO.BackColor = System.Drawing.Color.Thistle;
            this.ANCHO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANCHO.ForeColor = System.Drawing.Color.DarkViolet;
            this.ANCHO.Location = new System.Drawing.Point(3, 48);
            this.ANCHO.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ANCHO.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ANCHO.Name = "ANCHO";
            this.ANCHO.Size = new System.Drawing.Size(71, 32);
            this.ANCHO.TabIndex = 4;
            this.ANCHO.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ANCHO.ValueChanged += new System.EventHandler(this.ANCHO_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(219, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO. MINAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(111, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANCHO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ANCHO, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ALTO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.NUMMINAS, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(543, 90);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Personalizado);
            // 
            // Buscaminas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Buscaminas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Buscaminas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUMMINAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANCHO)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Fácil;
        private System.Windows.Forms.Button Medio;
        private System.Windows.Forms.Button Difícil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ANCHO;
        private System.Windows.Forms.NumericUpDown ALTO;
        private System.Windows.Forms.NumericUpDown NUMMINAS;
        private System.Windows.Forms.Button button1;
    }
}

