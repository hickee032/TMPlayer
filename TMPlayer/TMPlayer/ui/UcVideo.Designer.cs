namespace TMPlayer.ui {
    partial class UcVideo {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVideo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWmpPause = new System.Windows.Forms.Button();
            this.btnWmpStop = new System.Windows.Forms.Button();
            this.btnWmpPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wmpVideo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 472);
            this.panel3.TabIndex = 5;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(809, 472);
            this.wmpVideo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnOpenVideo);
            this.panel2.Controls.Add(this.btnWmpPause);
            this.panel2.Controls.Add(this.btnWmpStop);
            this.panel2.Controls.Add(this.btnWmpPlay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 56);
            this.panel2.TabIndex = 4;
            // 
            // btnWmpPause
            // 
            this.btnWmpPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWmpPause.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWmpPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWmpPause.Location = new System.Drawing.Point(136, 10);
            this.btnWmpPause.Name = "btnWmpPause";
            this.btnWmpPause.Size = new System.Drawing.Size(35, 35);
            this.btnWmpPause.TabIndex = 2;
            this.btnWmpPause.Text = "❚❚";
            this.btnWmpPause.UseVisualStyleBackColor = true;
            this.btnWmpPause.Click += new System.EventHandler(this.btnWmpPause_Click);
            // 
            // btnWmpStop
            // 
            this.btnWmpStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWmpStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWmpStop.Location = new System.Drawing.Point(95, 10);
            this.btnWmpStop.Name = "btnWmpStop";
            this.btnWmpStop.Size = new System.Drawing.Size(35, 35);
            this.btnWmpStop.TabIndex = 1;
            this.btnWmpStop.Text = "■";
            this.btnWmpStop.UseVisualStyleBackColor = true;
            this.btnWmpStop.Click += new System.EventHandler(this.btnWmpStop_Click);
            // 
            // btnWmpPlay
            // 
            this.btnWmpPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWmpPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWmpPlay.Location = new System.Drawing.Point(54, 10);
            this.btnWmpPlay.Name = "btnWmpPlay";
            this.btnWmpPlay.Size = new System.Drawing.Size(35, 35);
            this.btnWmpPlay.TabIndex = 0;
            this.btnWmpPlay.Text = "▶️";
            this.btnWmpPlay.UseVisualStyleBackColor = true;
            this.btnWmpPlay.Click += new System.EventHandler(this.btnWmpPlay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 49);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title Name";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TMPlayer.Properties.Resources.playnext;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(177, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TMPlayer.Properties.Resources.playback;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(13, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.BackgroundImage = global::TMPlayer.Properties.Resources.openfile;
            this.btnOpenVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpenVideo.Location = new System.Drawing.Point(735, 9);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(40, 35);
            this.btnOpenVideo.TabIndex = 3;
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // UcVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcVideo";
            this.Size = new System.Drawing.Size(809, 577);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnWmpPause;
        private System.Windows.Forms.Button btnWmpStop;
        private System.Windows.Forms.Button btnWmpPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
