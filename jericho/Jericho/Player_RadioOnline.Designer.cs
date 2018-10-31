namespace Jericho
{
    partial class Player_RadioOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_RadioOnline));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_vol_mais = new System.Windows.Forms.Button();
            this.btn_Vol_menos = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this.btn_Anterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(166, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(260, 44);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(252, 0);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(8, 8);
            this.axWindowsMediaPlayer2.TabIndex = 1;
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(94, 145);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(185, 145);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_vol_mais
            // 
            this.btn_vol_mais.Location = new System.Drawing.Point(287, 145);
            this.btn_vol_mais.Name = "btn_vol_mais";
            this.btn_vol_mais.Size = new System.Drawing.Size(75, 23);
            this.btn_vol_mais.TabIndex = 4;
            this.btn_vol_mais.Text = "Volume+";
            this.btn_vol_mais.UseVisualStyleBackColor = true;
            this.btn_vol_mais.Click += new System.EventHandler(this.btn_vol_mais_Click);
            // 
            // btn_Vol_menos
            // 
            this.btn_Vol_menos.Location = new System.Drawing.Point(377, 144);
            this.btn_Vol_menos.Name = "btn_Vol_menos";
            this.btn_Vol_menos.Size = new System.Drawing.Size(109, 24);
            this.btn_Vol_menos.TabIndex = 5;
            this.btn_Vol_menos.Text = "Volume-";
            this.btn_Vol_menos.UseVisualStyleBackColor = true;
            this.btn_Vol_menos.Click += new System.EventHandler(this.btn_Vol_menos_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Location = new System.Drawing.Point(166, 209);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_Proximo.TabIndex = 6;
            this.btn_Proximo.Text = ">>";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(287, 209);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_Anterior.TabIndex = 7;
            this.btn_Anterior.Text = "<<";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            // 
            // Player_RadioOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 451);
            this.Controls.Add(this.btn_Anterior);
            this.Controls.Add(this.btn_Proximo);
            this.Controls.Add(this.btn_Vol_menos);
            this.Controls.Add(this.btn_vol_mais);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Player_RadioOnline";
            this.Text = "Player_RadioOnline";
            this.Load += new System.EventHandler(this.Player_RadioOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_vol_mais;
        private System.Windows.Forms.Button btn_Vol_menos;
        private System.Windows.Forms.Button btn_Proximo;
        private System.Windows.Forms.Button btn_Anterior;
    }
}