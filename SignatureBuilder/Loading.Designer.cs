namespace SignatureBuilder
{
    partial class Loading
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.pBar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainTitle = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.Panel();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.BottomPanel.SuspendLayout();
            this.ProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(262, 10);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BottomPanel.Controls.Add(this.ProgressBar);
            this.BottomPanel.Controls.Add(this.label4);
            this.BottomPanel.Controls.Add(this.label3);
            this.BottomPanel.Location = new System.Drawing.Point(0, 300);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(300, 100);
            this.BottomPanel.TabIndex = 5;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressBar.Controls.Add(this.pBar);
            this.ProgressBar.Location = new System.Drawing.Point(25, 80);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(261, 6);
            this.ProgressBar.TabIndex = 7;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(42, -1);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(104, 2);
            this.pBar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "英雄联盟签名生成器正在初始化中 请稍候";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "欢迎您 艾泽拉斯的召唤师";
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainTitle.ForeColor = System.Drawing.Color.DimGray;
            this.MainTitle.Location = new System.Drawing.Point(79, 47);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(173, 26);
            this.MainTitle.TabIndex = 7;
            this.MainTitle.Text = "SignatureBuilder";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.DimGray;
            this.Version.Location = new System.Drawing.Point(206, 73);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(0, 12);
            this.Version.TabIndex = 8;
            this.Version.Paint += new System.Windows.Forms.PaintEventHandler(this.Version_Paint);
            // 
            // icon
            // 
            this.icon.BackgroundImage = global::SignatureBuilder.Properties.Resources.Tray_48a;
            this.icon.Location = new System.Drawing.Point(25, 25);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(48, 48);
            this.icon.TabIndex = 4;
            // 
            // LoadTimer
            // 
            this.LoadTimer.Enabled = true;
            this.LoadTimer.Interval = 10;
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.icon);
            this.Name = "Loading";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Controls.SetChildIndex(this.title, 0);
            this.Controls.SetChildIndex(this.titleboard, 0);
            this.Controls.SetChildIndex(this.icon, 0);
            this.Controls.SetChildIndex(this.BottomPanel, 0);
            this.Controls.SetChildIndex(this.MainTitle, 0);
            this.Controls.SetChildIndex(this.Version, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Panel ProgressBar;
        public System.Windows.Forms.Timer LoadTimer;
        private System.Windows.Forms.Panel pBar;

    }
}