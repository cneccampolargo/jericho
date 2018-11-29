namespace Jericho
{
    partial class telaHelp
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
            this.ListaAjuda = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaAjuda
            // 
            this.ListaAjuda.BackgroundColor = System.Drawing.Color.Black;
            this.ListaAjuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAjuda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListaAjuda.Location = new System.Drawing.Point(68, 186);
            this.ListaAjuda.Name = "ListaAjuda";
            this.ListaAjuda.Size = new System.Drawing.Size(1067, 331);
            this.ListaAjuda.TabIndex = 0;
            this.ListaAjuda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAjuda_CellContentClick);
            this.ListaAjuda.DoubleClick += new System.EventHandler(this.ListaAjuda_DoubleClick);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Stencil", 99.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_titulo.Location = new System.Drawing.Point(359, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(483, 158);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "AJUDA";
            // 
            // button1
            // 
            this.button1.Image = global::Jericho.Properties.Resources.istockphoto_495665922_1024x1024;
            this.button1.Location = new System.Drawing.Point(951, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telaHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1338, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.ListaAjuda);
            this.Name = "telaHelp";
            this.Text = "telaHelp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ListaAjuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaAjuda;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button button1;
    }
}