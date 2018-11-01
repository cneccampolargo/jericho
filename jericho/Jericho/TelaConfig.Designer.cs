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
            this.lbVoz = new System.Windows.Forms.Label();
            this.lbVolume = new System.Windows.Forms.Label();
            this.selectVoz = new System.Windows.Forms.ComboBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(149, 219);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(138, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "ATUALIZAR CONFIG";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(138, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(39, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(198, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(109, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lbVoz
            // 
            this.lbVoz.AutoSize = true;
            this.lbVoz.Location = new System.Drawing.Point(140, 108);
            this.lbVoz.Name = "lbVoz";
            this.lbVoz.Size = new System.Drawing.Size(29, 13);
            this.lbVoz.TabIndex = 5;
            this.lbVoz.Text = "VOZ";
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Location = new System.Drawing.Point(130, 152);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(52, 13);
            this.lbVolume.TabIndex = 6;
            this.lbVolume.Text = "VOLUME";
            // 
            // selectVoz
            // 
            this.selectVoz.FormattingEnabled = true;
            this.selectVoz.Location = new System.Drawing.Point(198, 104);
            this.selectVoz.Name = "selectVoz";
            this.selectVoz.Size = new System.Drawing.Size(109, 21);
            this.selectVoz.TabIndex = 7;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(189, 141);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(118, 45);
            this.trackVolume.TabIndex = 8;
            // 
            // TelaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 271);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.selectVoz);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.lbVoz);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "TelaConfig";
            this.Text = "TelaConfig";
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbVoz;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.ComboBox selectVoz;
        private System.Windows.Forms.TrackBar trackVolume;
    }
}