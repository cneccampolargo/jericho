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
            this.btn_Play = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_volumeMais = new System.Windows.Forms.Button();
            this.btn_volumeMenos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(141, 166);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(69, 48);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(128, 79);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(220, 42);
            this.Player.TabIndex = 1;
            this.Player.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(226, 166);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(69, 48);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(313, 166);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(69, 48);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_volumeMais
            // 
            this.btn_volumeMais.Location = new System.Drawing.Point(141, 248);
            this.btn_volumeMais.Name = "btn_volumeMais";
            this.btn_volumeMais.Size = new System.Drawing.Size(69, 48);
            this.btn_volumeMais.TabIndex = 4;
            this.btn_volumeMais.Text = "Volume +";
            this.btn_volumeMais.UseVisualStyleBackColor = true;
            this.btn_volumeMais.Click += new System.EventHandler(this.btn_volumeMais_Click);
            // 
            // btn_volumeMenos
            // 
            this.btn_volumeMenos.Location = new System.Drawing.Point(226, 248);
            this.btn_volumeMenos.Name = "btn_volumeMenos";
            this.btn_volumeMenos.Size = new System.Drawing.Size(69, 48);
            this.btn_volumeMenos.TabIndex = 5;
            this.btn_volumeMenos.Text = "Volume -";
            this.btn_volumeMenos.UseVisualStyleBackColor = true;
            this.btn_volumeMenos.Click += new System.EventHandler(this.btn_volumeMenos_Click);
            // 
            // Player_Mp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 507);
            this.Controls.Add(this.btn_volumeMenos);
            this.Controls.Add(this.btn_volumeMais);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.btn_Play);
            this.Name = "Player_Mp3";
            this.Text = "Player_Mp3";
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
        private System.Windows.Forms.Button btn_volumeMais;
        private System.Windows.Forms.Button btn_volumeMenos;
    }
}