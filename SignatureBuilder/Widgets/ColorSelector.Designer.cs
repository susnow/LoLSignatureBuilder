namespace SignatureBuilder.Widgets
{
    partial class ColorSelector
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
            this.colors = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Size = new System.Drawing.Size(65, 19);
            this.title.Text = "选择颜色";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(280, 10);
            // 
            // colors
            // 
            this.colors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colors.Location = new System.Drawing.Point(19, 49);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(275, 156);
            this.colors.TabIndex = 18;
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 229);
            this.Controls.Add(this.colors);
            this.Name = "ColorSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择颜色";
            this.Controls.SetChildIndex(this.title, 0);
            this.Controls.SetChildIndex(this.titleboard, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.colors, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colors;

    }
}