namespace Jericho
{
    partial class EscolhaAjuda
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_TextoAjuda = new System.Windows.Forms.Label();
            this.lbl_tit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Voltar.Image = global::Jericho.Properties.Resources.istockphoto_495665922_1024x1024;
            this.btn_Voltar.Location = new System.Drawing.Point(12, 285);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(175, 104);
            this.btn_Voltar.TabIndex = 0;
            this.btn_Voltar.Text = "VOLTAR";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_TextoAjuda
            // 
            this.lbl_TextoAjuda.AutoSize = true;
            this.lbl_TextoAjuda.Location = new System.Drawing.Point(212, 79);
            this.lbl_TextoAjuda.Name = "lbl_TextoAjuda";
            this.lbl_TextoAjuda.Size = new System.Drawing.Size(35, 13);
            this.lbl_TextoAjuda.TabIndex = 1;
            this.lbl_TextoAjuda.Text = "label1";
            // 
            // lbl_tit
            // 
            this.lbl_tit.AutoSize = true;
            this.lbl_tit.Font = new System.Drawing.Font("Stencil", 99.75F, System.Drawing.FontStyle.Bold);
            this.lbl_tit.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_tit.Location = new System.Drawing.Point(139, 26);
            this.lbl_tit.Name = "lbl_tit";
            this.lbl_tit.Size = new System.Drawing.Size(0, 158);
            this.lbl_tit.TabIndex = 2;
            this.lbl_tit.Click += new System.EventHandler(this.lbl_tit_Click);
            // 
            // EscolhaAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(603, 401);
            this.Controls.Add(this.lbl_tit);
            this.Controls.Add(this.lbl_TextoAjuda);
            this.Controls.Add(this.btn_Voltar);
            this.Name = "EscolhaAjuda";
            this.Text = "EscolhaAjuda";
            this.Load += new System.EventHandler(this.EscolhaAjuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_TextoAjuda;
        private System.Windows.Forms.Label lbl_tit;
    }
}