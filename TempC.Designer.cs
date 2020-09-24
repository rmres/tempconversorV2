namespace ConvTempV2
{
    partial class F_TemperatureConversor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TemperatureConversor));
            this.cbx_temps = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_result1 = new System.Windows.Forms.Label();
            this.lb_result2 = new System.Windows.Forms.Label();
            this.gb_results = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gb_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_temps
            // 
            this.cbx_temps.BackColor = System.Drawing.SystemColors.Window;
            this.cbx_temps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_temps.FormattingEnabled = true;
            this.cbx_temps.Items.AddRange(new object[] {
            "Celsius (ºC)",
            "Fahrenheit (ºF)",
            "Kelvin (K)"});
            this.cbx_temps.Location = new System.Drawing.Point(11, 111);
            this.cbx_temps.Name = "cbx_temps";
            this.cbx_temps.Size = new System.Drawing.Size(218, 21);
            this.cbx_temps.TabIndex = 0;
            this.cbx_temps.SelectedIndexChanged += new System.EventHandler(this.cbx_temps_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 154);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lb_result1
            // 
            this.lb_result1.AutoSize = true;
            this.lb_result1.Location = new System.Drawing.Point(6, 29);
            this.lb_result1.Name = "lb_result1";
            this.lb_result1.Size = new System.Drawing.Size(94, 13);
            this.lb_result1.TabIndex = 2;
            this.lb_result1.Text = "Aguardando valor.";
            // 
            // lb_result2
            // 
            this.lb_result2.AutoSize = true;
            this.lb_result2.Location = new System.Drawing.Point(6, 63);
            this.lb_result2.Name = "lb_result2";
            this.lb_result2.Size = new System.Drawing.Size(0, 13);
            this.lb_result2.TabIndex = 3;
            // 
            // gb_results
            // 
            this.gb_results.Controls.Add(this.lb_result1);
            this.gb_results.Controls.Add(this.lb_result2);
            this.gb_results.Location = new System.Drawing.Point(11, 197);
            this.gb_results.Name = "gb_results";
            this.gb_results.Size = new System.Drawing.Size(218, 100);
            this.gb_results.TabIndex = 4;
            this.gb_results.TabStop = false;
            this.gb_results.Text = "Resultados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione a temperatura que você possui:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConvTempV2.Properties.Resources.thermo;
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conversor de\r\ntemperatura";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(189, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // F_TemperatureConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(241, 323);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_results);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbx_temps);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_TemperatureConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.gb_results.ResumeLayout(false);
            this.gb_results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_temps;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_result1;
        private System.Windows.Forms.Label lb_result2;
        private System.Windows.Forms.GroupBox gb_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

