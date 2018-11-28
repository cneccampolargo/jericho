namespace Jericho
{
    partial class Player_Mp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Mp3));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_volumeMenos = new System.Windows.Forms.Button();
            this.btn_volumeMais = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 40);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(220, 42);
            this.Player.TabIndex = 0;
            this.Player.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Jericho.Properties.Resources.Google_Play_Music_icon;
            this.button1.Location = new System.Drawing.Point(471, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(432, 374);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_volumeMenos
            // 
            this.btn_volumeMenos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_volumeMenos.ForeColor = System.Drawing.Color.Gold;
            this.btn_volumeMenos.Image = global::Jericho.Properties.Resources.Sem_título;
            this.btn_volumeMenos.Location = new System.Drawing.Point(60, 445);
            this.btn_volumeMenos.Name = "btn_volumeMenos";
            this.btn_volumeMenos.Size = new System.Drawing.Size(193, 189);
            this.btn_volumeMenos.TabIndex = 1;
            this.btn_volumeMenos.UseVisualStyleBackColor = false;
            this.btn_volumeMenos.Click += new System.EventHandler(this.btn_volumeMenos_Click);
            // 
            // btn_volumeMais
            // 
            this.btn_volumeMais.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_volumeMais.ForeColor = System.Drawing.Color.Gold;
            this.btn_volumeMais.Image = global::Jericho.Properties.Resources.Sem_título623;
            this.btn_volumeMais.Location = new System.Drawing.Point(319, 445);
            this.btn_volumeMais.Name = "btn_volumeMais";
            this.btn_volumeMais.Size = new System.Drawing.Size(193, 193);
            this.btn_volumeMais.TabIndex = 2;
            this.btn_volumeMais.UseVisualStyleBackColor = false;
            this.btn_volumeMais.Click += new System.EventHandler(this.btn_volumeMais_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.ForeColor = System.Drawing.Color.Gold;
            this.btn_stop.Image = global::Jericho.Properties.Resources.Sem_título444;
            this.btn_stop.Location = new System.Drawing.Point(593, 445);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(193, 189);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_pause.ForeColor = System.Drawing.Color.Gold;
            this.btn_pause.Image = global::Jericho.Properties.Resources.Sem_título555;
            this.btn_pause.Location = new System.Drawing.Point(866, 445);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(193, 189);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Image = global::Jericho.Properties.Resources.black_youtube_logo_pngd1e_4b74_b2e7_745c6b3c0add;
            this.btn_Play.Location = new System.Drawing.Point(1118, 445);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(193, 189);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // Player_Mp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1250, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_volumeMenos);
            this.Controls.Add(this.btn_volumeMais);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btn_Play);
            this.Name = "Player_Mp3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player_Mp3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Player_Mp3_FormClosing);
            this.Load += new System.EventHandler(this.Player_Mp3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_volumeMenos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_volumeMais;
    }
}