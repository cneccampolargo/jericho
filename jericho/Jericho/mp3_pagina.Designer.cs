namespace Jericho
{
    partial class mp3_pagina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 62);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.ARTISTA,
            this.GENERO,
            this.DATA});
            this.dataGridView1.Location = new System.Drawing.Point(149, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 359);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // NOME
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.DefaultCellStyle = dataGridViewCellStyle2;
            this.NOME.FillWeight = 250F;
            this.NOME.HeaderText = "NOME DA MUSICA";
            this.NOME.Name = "NOME";
            this.NOME.Width = 300;
            // 
            // ARTISTA
            // 
            this.ARTISTA.HeaderText = "ARTISTA";
            this.ARTISTA.Name = "ARTISTA";
            this.ARTISTA.Width = 300;
            // 
            // GENERO
            // 
            this.GENERO.HeaderText = "GENERO";
            this.GENERO.Name = "GENERO";
            this.GENERO.Width = 200;
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA ADICIONADO";
            this.DATA.Name = "DATA";
            this.DATA.Width = 150;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(434, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Image = global::Jericho.Properties.Resources.Sem_Título_3;
            this.button5.Location = new System.Drawing.Point(69, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 135);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Jericho.Properties.Resources.gettyimages_663936454_170x170;
            this.button4.Location = new System.Drawing.Point(1051, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 168);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Jericho.Properties.Resources.gettyimages_663936454_170x170;
            this.button3.Location = new System.Drawing.Point(246, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 168);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Jericho.Properties.Resources.avatars_000356896430_cvwzvd_t500x500;
            this.button1.Location = new System.Drawing.Point(476, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(524, 156);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mp3_pagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1295, 606);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "mp3_pagina";
            this.Text = "mp3_pagina";
            this.Load += new System.EventHandler(this.mp3_pagina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}