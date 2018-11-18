namespace Jericho
{
    partial class TelaConfig
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.selectVoz = new System.Windows.Forms.ComboBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizar.Location = new System.Drawing.Point(462, 538);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(686, 57);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "ATUALIZAR CONFIGURAÇÃO";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Stencil", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Gold;
            this.lbNome.Location = new System.Drawing.Point(12, 205);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(255, 95);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "NOME";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(270, 216);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(996, 80);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // selectVoz
            // 
            this.selectVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVoz.FormattingEnabled = true;
            this.selectVoz.Location = new System.Drawing.Point(270, 348);
            this.selectVoz.Name = "selectVoz";
            this.selectVoz.Size = new System.Drawing.Size(996, 81);
            this.selectVoz.TabIndex = 7;
            this.selectVoz.SelectedIndexChanged += new System.EventHandler(this.selectVoz_SelectedIndexChanged);
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(411, 496);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(820, 45);
            this.trackVolume.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Jericho.Properties.Resources.icon_gear_white1;
            this.button1.Location = new System.Drawing.Point(560, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 209);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Stencil", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(12, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 90);
            this.button3.TabIndex = 11;
            this.button3.Text = "VOZ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "\'";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Stencil", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(12, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(375, 104);
            this.button4.TabIndex = 14;
            this.button4.Text = "VOLUME";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TelaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1292, 607);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.selectVoz);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "TelaConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaConfig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox selectVoz;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}