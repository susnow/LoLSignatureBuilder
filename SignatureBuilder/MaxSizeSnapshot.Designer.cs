namespace SignatureBuilder
{
    partial class MaxSizeSnapshot
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
            this.ShotPanel = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.cutBox = new SignatureBuilder.Widgets.CutBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1201, 10);
            // 
            // ShotPanel
            // 
            this.ShotPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShotPanel.Location = new System.Drawing.Point(12, 42);
            this.ShotPanel.Name = "ShotPanel";
            this.ShotPanel.Size = new System.Drawing.Size(1215, 717);
            this.ShotPanel.TabIndex = 18;
            this.ShotPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShotPanel_MouseDown);
            this.ShotPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShotPanel_MouseMove);
            this.ShotPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShotPanel_MouseUp);
            this.ShotPanel.Resize += new System.EventHandler(this.ShotPanel_Resize);
            // 
            // cutBox
            // 
            this.cutBox.BackColor = System.Drawing.Color.Transparent;
            this.cutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cutBox.Location = new System.Drawing.Point(226, 24);
            this.cutBox.Name = "cutBox";
            this.cutBox.Size = new System.Drawing.Size(1, 1);
            this.cutBox.TabIndex = 0;
            this.cutBox.Visible = false;
            // 
            // MaxSizeSnapshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 770);
            this.Controls.Add(this.cutBox);
            this.Controls.Add(this.ShotPanel);
            this.Name = "MaxSizeSnapshot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaxSizeSnapshot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormClosing);
            this.Controls.SetChildIndex(this.title, 0);
            this.Controls.SetChildIndex(this.titleboard, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.ShotPanel, 0);
            this.Controls.SetChildIndex(this.cutBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Widgets.BackGroundPanelTrend ShotPanel;
        private Widgets.CutBox cutBox;
    }
}