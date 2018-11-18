namespace Jericho
{
    partial class TelaFiles
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
            this.btnBuscarFile = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbBanda = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            this.lbNomeFile = new System.Windows.Forms.Label();
            this.txtBanda = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtNomeFile = new System.Windows.Forms.TextBox();
            this.btnMoverFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarFile
            // 
            this.btnBuscarFile.Location = new System.Drawing.Point(71, 245);
            this.btnBuscarFile.Name = "btnBuscarFile";
            this.btnBuscarFile.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarFile.TabIndex = 0;
            this.btnBuscarFile.Text = "BUSCAR...";
            this.btnBuscarFile.UseVisualStyleBackColor = true;
            this.btnBuscarFile.Click += new System.EventHandler(this.btnBuscarFile_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(120, 48);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(39, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lbBanda
            // 
            this.lbBanda.AutoSize = true;
            this.lbBanda.Location = new System.Drawing.Point(115, 82);
            this.lbBanda.Name = "lbBanda";
            this.lbBanda.Size = new System.Drawing.Size(44, 13);
            this.lbBanda.TabIndex = 3;
            this.lbBanda.Text = "BANDA";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(114, 120);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(53, 13);
            this.lbGenero.TabIndex = 4;
            this.lbGenero.Text = "GENERO";
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(124, 154);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(29, 13);
            this.lbUrl.TabIndex = 5;
            this.lbUrl.Text = "URL";
            // 
            // lbNomeFile
            // 
            this.lbNomeFile.AutoSize = true;
            this.lbNomeFile.Location = new System.Drawing.Point(109, 192);
            this.lbNomeFile.Name = "lbNomeFile";
            this.lbNomeFile.Size = new System.Drawing.Size(64, 13);
            this.lbNomeFile.TabIndex = 6;
            this.lbNomeFile.Text = "NOME FILE";
            // 
            // txtBanda
            // 
            this.txtBanda.Location = new System.Drawing.Point(191, 79);
            this.txtBanda.Name = "txtBanda";
            this.txtBanda.Size = new System.Drawing.Size(100, 20);
            this.txtBanda.TabIndex = 7;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(191, 117);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(191, 151);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 20);
            this.txtUrl.TabIndex = 9;
            // 
            // txtNomeFile
            // 
            this.txtNomeFile.Location = new System.Drawing.Point(191, 189);
            this.txtNomeFile.Name = "txtNomeFile";
            this.txtNomeFile.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFile.TabIndex = 10;
            // 
            // btnMoverFile
            // 
            this.btnMoverFile.Location = new System.Drawing.Point(187, 245);
            this.btnMoverFile.Name = "btnMoverFile";
            this.btnMoverFile.Size = new System.Drawing.Size(142, 23);
            this.btnMoverFile.TabIndex = 11;
            this.btnMoverFile.Text = "MOVER ARQUIVO";
            this.btnMoverFile.UseVisualStyleBackColor = true;
            this.btnMoverFile.Click += new System.EventHandler(this.btnMoverFile_Click);
            // 
            // TelaFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 577);
            this.Controls.Add(this.btnMoverFile);
            this.Controls.Add(this.txtNomeFile);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtBanda);
            this.Controls.Add(this.lbNomeFile);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbBanda);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnBuscarFile);
            this.Name = "TelaFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarFile;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbBanda;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Label lbNomeFile;
        private System.Windows.Forms.TextBox txtBanda;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtNomeFile;
        private System.Windows.Forms.Button btnMoverFile;
    }
}