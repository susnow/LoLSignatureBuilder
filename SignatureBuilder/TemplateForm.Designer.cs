namespace SignatureBuilder
{
    partial class TemplateForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.TopBoardPanel = new System.Windows.Forms.Panel();
            this.BottomBoardPanel = new System.Windows.Forms.Panel();
            this.RightBoardPanel = new System.Windows.Forms.Panel();
            this.LeftBoardPanel = new System.Windows.Forms.Panel();
            this.titleboard = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TopBoardPanel
            // 
            this.TopBoardPanel.Location = new System.Drawing.Point(61, 238);
            this.TopBoardPanel.Name = "TopBoardPanel";
            this.TopBoardPanel.Size = new System.Drawing.Size(11, 100);
            this.TopBoardPanel.TabIndex = 0;
            // 
            // BottomBoardPanel
            // 
            this.BottomBoardPanel.Location = new System.Drawing.Point(88, 240);
            this.BottomBoardPanel.Name = "BottomBoardPanel";
            this.BottomBoardPanel.Size = new System.Drawing.Size(11, 100);
            this.BottomBoardPanel.TabIndex = 1;
            // 
            // RightBoardPanel
            // 
            this.RightBoardPanel.Location = new System.Drawing.Point(175, 240);
            this.RightBoardPanel.Name = "RightBoardPanel";
            this.RightBoardPanel.Size = new System.Drawing.Size(11, 100);
            this.RightBoardPanel.TabIndex = 1;
            // 
            // LeftBoardPanel
            // 
            this.LeftBoardPanel.Location = new System.Drawing.Point(118, 240);
            this.LeftBoardPanel.Name = "LeftBoardPanel";
            this.LeftBoardPanel.Size = new System.Drawing.Size(11, 100);
            this.LeftBoardPanel.TabIndex = 2;
            // 
            // titleboard
            // 
            this.titleboard.BackColor = System.Drawing.Color.DarkOrange;
            this.titleboard.Location = new System.Drawing.Point(2, 2);
            this.titleboard.Name = "titleboard";
            this.titleboard.Size = new System.Drawing.Size(7, 25);
            this.titleboard.TabIndex = 16;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(15, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(51, 19);
            this.title.TabIndex = 15;
            this.title.Text = "label1";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.close24_black;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(248, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseEnter);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.titleboard);
            this.Controls.Add(this.title);
            this.Controls.Add(this.LeftBoardPanel);
            this.Controls.Add(this.RightBoardPanel);
            this.Controls.Add(this.BottomBoardPanel);
            this.Controls.Add(this.TopBoardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TemplateForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.TemplateForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ParentMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ParentMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ParentMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBoardPanel;
        private System.Windows.Forms.Panel BottomBoardPanel;
        private System.Windows.Forms.Panel RightBoardPanel;
        private System.Windows.Forms.Panel LeftBoardPanel;
        protected System.Windows.Forms.Panel titleboard;
        protected System.Windows.Forms.Label title;
        protected System.Windows.Forms.Panel CloseButton;

    }
}

