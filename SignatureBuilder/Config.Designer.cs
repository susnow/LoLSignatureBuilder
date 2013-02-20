namespace SignatureBuilder
{
    partial class Config
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
            this.ClientPathSelectButton = new System.Windows.Forms.Panel();
            this.ClientSelectButtonLabel = new System.Windows.Forms.Label();
            this.ClientPathPanel = new System.Windows.Forms.Panel();
            this.ClientPathLabel = new System.Windows.Forms.Label();
            this.ClientInfoLabel = new System.Windows.Forms.Label();
            this.SigSavePathSelectButton = new System.Windows.Forms.Panel();
            this.SigSavePathSelectLabel = new System.Windows.Forms.Label();
            this.SigSavePathPanel = new System.Windows.Forms.Panel();
            this.SigSavePathLabel = new System.Windows.Forms.Label();
            this.SigSaveInfoLabel = new System.Windows.Forms.Label();
            this.ClientPathSelectButton.SuspendLayout();
            this.ClientPathPanel.SuspendLayout();
            this.SigSavePathSelectButton.SuspendLayout();
            this.SigSavePathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(404, 10);
            // 
            // ClientPathSelectButton
            // 
            this.ClientPathSelectButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPathSelectButton.Controls.Add(this.ClientSelectButtonLabel);
            this.ClientPathSelectButton.Location = new System.Drawing.Point(375, 48);
            this.ClientPathSelectButton.Name = "ClientPathSelectButton";
            this.ClientPathSelectButton.Size = new System.Drawing.Size(33, 26);
            this.ClientPathSelectButton.TabIndex = 20;
            this.ClientPathSelectButton.Click += new System.EventHandler(this.ClientButton_Click);
            this.ClientPathSelectButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ClientPathSelectButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.ClientPathSelectButton.MouseHover += new System.EventHandler(this.Button_MouseEnter);
            // 
            // ClientSelectButtonLabel
            // 
            this.ClientSelectButtonLabel.AutoSize = true;
            this.ClientSelectButtonLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSelectButtonLabel.Location = new System.Drawing.Point(7, 6);
            this.ClientSelectButtonLabel.Name = "ClientSelectButtonLabel";
            this.ClientSelectButtonLabel.Size = new System.Drawing.Size(17, 12);
            this.ClientSelectButtonLabel.TabIndex = 5;
            this.ClientSelectButtonLabel.Text = "…";
            this.ClientSelectButtonLabel.Click += new System.EventHandler(this.ClientButton_Click);
            this.ClientSelectButtonLabel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ClientSelectButtonLabel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.ClientSelectButtonLabel.MouseHover += new System.EventHandler(this.Button_MouseEnter);
            // 
            // ClientPathPanel
            // 
            this.ClientPathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPathPanel.Controls.Add(this.ClientPathLabel);
            this.ClientPathPanel.Location = new System.Drawing.Point(102, 48);
            this.ClientPathPanel.Name = "ClientPathPanel";
            this.ClientPathPanel.Size = new System.Drawing.Size(267, 26);
            this.ClientPathPanel.TabIndex = 19;
            // 
            // ClientPathLabel
            // 
            this.ClientPathLabel.AutoSize = true;
            this.ClientPathLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPathLabel.Location = new System.Drawing.Point(4, 6);
            this.ClientPathLabel.Name = "ClientPathLabel";
            this.ClientPathLabel.Size = new System.Drawing.Size(167, 12);
            this.ClientPathLabel.TabIndex = 2;
            this.ClientPathLabel.Text = "x:/英雄联盟/TCLS/Client.exe";
            // 
            // ClientInfoLabel
            // 
            this.ClientInfoLabel.AutoSize = true;
            this.ClientInfoLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientInfoLabel.Location = new System.Drawing.Point(28, 54);
            this.ClientInfoLabel.Name = "ClientInfoLabel";
            this.ClientInfoLabel.Size = new System.Drawing.Size(68, 17);
            this.ClientInfoLabel.TabIndex = 18;
            this.ClientInfoLabel.Text = "客户端路径";
            // 
            // SigSavePathSelectButton
            // 
            this.SigSavePathSelectButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SigSavePathSelectButton.Controls.Add(this.SigSavePathSelectLabel);
            this.SigSavePathSelectButton.Location = new System.Drawing.Point(375, 92);
            this.SigSavePathSelectButton.Name = "SigSavePathSelectButton";
            this.SigSavePathSelectButton.Size = new System.Drawing.Size(33, 26);
            this.SigSavePathSelectButton.TabIndex = 23;
            this.SigSavePathSelectButton.Click += new System.EventHandler(this.SigFolderButton_Click);
            this.SigSavePathSelectButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SigSavePathSelectButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.SigSavePathSelectButton.MouseHover += new System.EventHandler(this.Button_MouseEnter);
            // 
            // SigSavePathSelectLabel
            // 
            this.SigSavePathSelectLabel.AutoSize = true;
            this.SigSavePathSelectLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SigSavePathSelectLabel.Location = new System.Drawing.Point(7, 6);
            this.SigSavePathSelectLabel.Name = "SigSavePathSelectLabel";
            this.SigSavePathSelectLabel.Size = new System.Drawing.Size(17, 12);
            this.SigSavePathSelectLabel.TabIndex = 5;
            this.SigSavePathSelectLabel.Text = "…";
            this.SigSavePathSelectLabel.Click += new System.EventHandler(this.SigFolderButton_Click);
            this.SigSavePathSelectLabel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SigSavePathSelectLabel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.SigSavePathSelectLabel.MouseHover += new System.EventHandler(this.Button_MouseEnter);
            // 
            // SigSavePathPanel
            // 
            this.SigSavePathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SigSavePathPanel.Controls.Add(this.SigSavePathLabel);
            this.SigSavePathPanel.Location = new System.Drawing.Point(102, 92);
            this.SigSavePathPanel.Name = "SigSavePathPanel";
            this.SigSavePathPanel.Size = new System.Drawing.Size(267, 26);
            this.SigSavePathPanel.TabIndex = 22;
            // 
            // SigSavePathLabel
            // 
            this.SigSavePathLabel.AutoSize = true;
            this.SigSavePathLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigSavePathLabel.Location = new System.Drawing.Point(4, 6);
            this.SigSavePathLabel.Name = "SigSavePathLabel";
            this.SigSavePathLabel.Size = new System.Drawing.Size(167, 12);
            this.SigSavePathLabel.TabIndex = 2;
            this.SigSavePathLabel.Text = "x:/英雄联盟/TCLS/Client.exe";
            // 
            // SigSaveInfoLabel
            // 
            this.SigSaveInfoLabel.AutoSize = true;
            this.SigSaveInfoLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SigSaveInfoLabel.Location = new System.Drawing.Point(16, 96);
            this.SigSaveInfoLabel.Name = "SigSaveInfoLabel";
            this.SigSaveInfoLabel.Size = new System.Drawing.Size(80, 17);
            this.SigSaveInfoLabel.TabIndex = 21;
            this.SigSaveInfoLabel.Text = "签名保存路径";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 140);
            this.Controls.Add(this.SigSavePathSelectButton);
            this.Controls.Add(this.SigSavePathPanel);
            this.Controls.Add(this.SigSaveInfoLabel);
            this.Controls.Add(this.ClientPathSelectButton);
            this.Controls.Add(this.ClientPathPanel);
            this.Controls.Add(this.ClientInfoLabel);
            this.Name = "Config";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.Controls.SetChildIndex(this.title, 0);
            this.Controls.SetChildIndex(this.titleboard, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.ClientInfoLabel, 0);
            this.Controls.SetChildIndex(this.ClientPathPanel, 0);
            this.Controls.SetChildIndex(this.ClientPathSelectButton, 0);
            this.Controls.SetChildIndex(this.SigSaveInfoLabel, 0);
            this.Controls.SetChildIndex(this.SigSavePathPanel, 0);
            this.Controls.SetChildIndex(this.SigSavePathSelectButton, 0);
            this.ClientPathSelectButton.ResumeLayout(false);
            this.ClientPathSelectButton.PerformLayout();
            this.ClientPathPanel.ResumeLayout(false);
            this.ClientPathPanel.PerformLayout();
            this.SigSavePathSelectButton.ResumeLayout(false);
            this.SigSavePathSelectButton.PerformLayout();
            this.SigSavePathPanel.ResumeLayout(false);
            this.SigSavePathPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ClientPathSelectButton;
        private System.Windows.Forms.Label ClientSelectButtonLabel;
        private System.Windows.Forms.Panel ClientPathPanel;
        private System.Windows.Forms.Label ClientPathLabel;
        private System.Windows.Forms.Label ClientInfoLabel;
        private System.Windows.Forms.Panel SigSavePathSelectButton;
        private System.Windows.Forms.Label SigSavePathSelectLabel;
        private System.Windows.Forms.Panel SigSavePathPanel;
        private System.Windows.Forms.Label SigSavePathLabel;
        private System.Windows.Forms.Label SigSaveInfoLabel;
    }
}