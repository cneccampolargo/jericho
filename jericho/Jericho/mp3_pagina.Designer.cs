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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataGridMusicas = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // DataGridMusicas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridMusicas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridMusicas.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.DataGridMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridMusicas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridMusicas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridMusicas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridMusicas.Location = new System.Drawing.Point(157, 391);
            this.DataGridMusicas.Name = "DataGridMusicas";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridMusicas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridMusicas.Size = new System.Drawing.Size(996, 359);
            this.DataGridMusicas.TabIndex = 3;
            this.DataGridMusicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.DataGridMusicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.DataGridMusicas.DoubleClick += new System.EventHandler(this.DataGridMusicas_DoubleClick);
            // 
            // button5
            // 
            this.button5.Image = global::Jericho.Properties.Resources.Sem_Título_3;
            this.button5.Location = new System.Drawing.Point(69, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 135);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Jericho.Properties.Resources.gettyimages_663936454_170x170;
            this.button4.Location = new System.Drawing.Point(1051, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 168);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button4_KeyPress);
            // 
            // button3
            // 
            this.button3.Image = global::Jericho.Properties.Resources.gettyimages_663936454_170x170;
            this.button3.Location = new System.Drawing.Point(276, 57);
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
            this.Controls.Add(this.DataGridMusicas);
            this.Controls.Add(this.textBox1);
            this.Name = "mp3_pagina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mp3_pagina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mp3_pagina_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mp3_pagina_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMusicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DataGridMusicas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}