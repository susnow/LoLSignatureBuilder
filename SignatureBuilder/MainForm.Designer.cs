namespace SignatureBuilder
{
    partial class MainForm
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
            this.ListPanel = new System.Windows.Forms.Panel();
            this.PusherCB = new System.Windows.Forms.CheckBox();
            this.TankCB = new System.Windows.Forms.CheckBox();
            this.JungleCB = new System.Windows.Forms.CheckBox();
            this.SupportCB = new System.Windows.Forms.CheckBox();
            this.APCB = new System.Windows.Forms.CheckBox();
            this.ADCB = new System.Windows.Forms.CheckBox();
            this.RangeCB = new System.Windows.Forms.CheckBox();
            this.MeleeCB = new System.Windows.Forms.CheckBox();
            this.SearchChampionTextBox = new System.Windows.Forms.TextBox();
            this.SearchFilterPanel = new System.Windows.Forms.Panel();
            this.ResultListPanel = new System.Windows.Forms.Panel();
            this.ChampionPanel = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.ChampionSkinName = new System.Windows.Forms.Label();
            this.ChampionName = new System.Windows.Forms.Label();
            this.ChampionPortrait = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview0 = new System.Windows.Forms.Panel();
            this.SkinPreviewsPanel = new System.Windows.Forms.Panel();
            this.preview12 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview11 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview10 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview9 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview8 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview7 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview1 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview2 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview3 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview4 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview5 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.preview6 = new SignatureBuilder.Widgets.BackGroundPanelTrend();
            this.BackButton = new System.Windows.Forms.Panel();
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.stopInput = new System.Windows.Forms.Timer(this.components);
            this.stopChecked = new System.Windows.Forms.Timer(this.components);
            this.AboutButton = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Panel();
            this.cutBox = new SignatureBuilder.Widgets.CutBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.MaxSizeBox = new System.Windows.Forms.Panel();
            this.SkinPreviewPanel = new System.Windows.Forms.Panel();
            this.SearchFilterPanel.SuspendLayout();
            this.ChampionPanel.SuspendLayout();
            this.SkinPreviewsPanel.SuspendLayout();
            this.ParentPanel.SuspendLayout();
            this.SkinPreviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(832, 10);
            // 
            // ListPanel
            // 
            this.ListPanel.Location = new System.Drawing.Point(-1, -1);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(658, 1440);
            this.ListPanel.TabIndex = 17;
            this.ListPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_OnMouseWheel);
            // 
            // PusherCB
            // 
            this.PusherCB.AutoSize = true;
            this.PusherCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PusherCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PusherCB.Location = new System.Drawing.Point(25, 123);
            this.PusherCB.Name = "PusherCB";
            this.PusherCB.Size = new System.Drawing.Size(48, 21);
            this.PusherCB.TabIndex = 34;
            this.PusherCB.Text = "推进";
            this.PusherCB.UseVisualStyleBackColor = true;
            this.PusherCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.PusherCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.PusherCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // TankCB
            // 
            this.TankCB.AutoSize = true;
            this.TankCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TankCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TankCB.Location = new System.Drawing.Point(100, 124);
            this.TankCB.Name = "TankCB";
            this.TankCB.Size = new System.Drawing.Size(48, 21);
            this.TankCB.TabIndex = 32;
            this.TankCB.Text = "坦克";
            this.TankCB.UseVisualStyleBackColor = true;
            this.TankCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.TankCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.TankCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // JungleCB
            // 
            this.JungleCB.AutoSize = true;
            this.JungleCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JungleCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JungleCB.Location = new System.Drawing.Point(100, 97);
            this.JungleCB.Name = "JungleCB";
            this.JungleCB.Size = new System.Drawing.Size(48, 21);
            this.JungleCB.TabIndex = 37;
            this.JungleCB.Text = "打野";
            this.JungleCB.UseVisualStyleBackColor = true;
            this.JungleCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.JungleCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.JungleCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // SupportCB
            // 
            this.SupportCB.AutoSize = true;
            this.SupportCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SupportCB.Location = new System.Drawing.Point(25, 96);
            this.SupportCB.Name = "SupportCB";
            this.SupportCB.Size = new System.Drawing.Size(48, 21);
            this.SupportCB.TabIndex = 36;
            this.SupportCB.Text = "辅助";
            this.SupportCB.UseVisualStyleBackColor = true;
            this.SupportCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.SupportCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.SupportCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // APCB
            // 
            this.APCB.AutoSize = true;
            this.APCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.APCB.Location = new System.Drawing.Point(25, 69);
            this.APCB.Name = "APCB";
            this.APCB.Size = new System.Drawing.Size(48, 21);
            this.APCB.TabIndex = 35;
            this.APCB.Text = "法术";
            this.APCB.UseVisualStyleBackColor = true;
            this.APCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.APCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.APCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // ADCB
            // 
            this.ADCB.AutoSize = true;
            this.ADCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADCB.Location = new System.Drawing.Point(100, 69);
            this.ADCB.Name = "ADCB";
            this.ADCB.Size = new System.Drawing.Size(48, 21);
            this.ADCB.TabIndex = 33;
            this.ADCB.Text = "物理";
            this.ADCB.UseVisualStyleBackColor = true;
            this.ADCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.ADCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.ADCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // RangeCB
            // 
            this.RangeCB.AutoSize = true;
            this.RangeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RangeCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RangeCB.Location = new System.Drawing.Point(100, 42);
            this.RangeCB.Name = "RangeCB";
            this.RangeCB.Size = new System.Drawing.Size(48, 21);
            this.RangeCB.TabIndex = 31;
            this.RangeCB.Text = "远程";
            this.RangeCB.UseVisualStyleBackColor = true;
            this.RangeCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.RangeCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.RangeCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // MeleeCB
            // 
            this.MeleeCB.AutoSize = true;
            this.MeleeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeleeCB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MeleeCB.Location = new System.Drawing.Point(25, 42);
            this.MeleeCB.Name = "MeleeCB";
            this.MeleeCB.Size = new System.Drawing.Size(48, 21);
            this.MeleeCB.TabIndex = 30;
            this.MeleeCB.Text = "近战";
            this.MeleeCB.UseVisualStyleBackColor = true;
            this.MeleeCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.MeleeCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseClick);
            this.MeleeCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedBox_MouseUp);
            // 
            // SearchChampionTextBox
            // 
            this.SearchChampionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchChampionTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchChampionTextBox.Location = new System.Drawing.Point(15, 13);
            this.SearchChampionTextBox.Name = "SearchChampionTextBox";
            this.SearchChampionTextBox.Size = new System.Drawing.Size(133, 23);
            this.SearchChampionTextBox.TabIndex = 29;
            this.SearchChampionTextBox.TextChanged += new System.EventHandler(this.SearchChampionTextBox_TextChanged);
            this.SearchChampionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchChampionTextBox_KeyPress);
            this.SearchChampionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchChampionTextBox_KeyUp);
            // 
            // SearchFilterPanel
            // 
            this.SearchFilterPanel.Controls.Add(this.MeleeCB);
            this.SearchFilterPanel.Controls.Add(this.SearchChampionTextBox);
            this.SearchFilterPanel.Controls.Add(this.PusherCB);
            this.SearchFilterPanel.Controls.Add(this.RangeCB);
            this.SearchFilterPanel.Controls.Add(this.TankCB);
            this.SearchFilterPanel.Controls.Add(this.ADCB);
            this.SearchFilterPanel.Controls.Add(this.JungleCB);
            this.SearchFilterPanel.Controls.Add(this.APCB);
            this.SearchFilterPanel.Controls.Add(this.SupportCB);
            this.SearchFilterPanel.Location = new System.Drawing.Point(676, 55);
            this.SearchFilterPanel.Name = "SearchFilterPanel";
            this.SearchFilterPanel.Size = new System.Drawing.Size(173, 402);
            this.SearchFilterPanel.TabIndex = 18;
            // 
            // ResultListPanel
            // 
            this.ResultListPanel.Location = new System.Drawing.Point(-1, -1);
            this.ResultListPanel.Name = "ResultListPanel";
            this.ResultListPanel.Size = new System.Drawing.Size(658, 1440);
            this.ResultListPanel.TabIndex = 18;
            this.ResultListPanel.Visible = false;
            this.ResultListPanel.VisibleChanged += new System.EventHandler(this.Panel_VisibleChanged);
            this.ResultListPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_OnMouseWheel);
            // 
            // ChampionPanel
            // 
            this.ChampionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChampionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChampionPanel.Controls.Add(this.ChampionSkinName);
            this.ChampionPanel.Controls.Add(this.ChampionName);
            this.ChampionPanel.Controls.Add(this.ChampionPortrait);
            this.ChampionPanel.Location = new System.Drawing.Point(12, 55);
            this.ChampionPanel.Name = "ChampionPanel";
            this.ChampionPanel.Size = new System.Drawing.Size(658, 402);
            this.ChampionPanel.TabIndex = 19;
            this.ChampionPanel.Visible = false;
            this.ChampionPanel.VisibleChanged += new System.EventHandler(this.ChampionPanel_VisibleChanged);
            this.ChampionPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChampionPanel_MouseDown);
            this.ChampionPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChampionPanel_MouseUp);
            this.ChampionPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChampionPanel_MouseUp);
            // 
            // ChampionSkinName
            // 
            this.ChampionSkinName.AutoSize = true;
            this.ChampionSkinName.BackColor = System.Drawing.Color.Transparent;
            this.ChampionSkinName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ChampionSkinName.ForeColor = System.Drawing.SystemColors.Control;
            this.ChampionSkinName.Location = new System.Drawing.Point(101, 47);
            this.ChampionSkinName.Name = "ChampionSkinName";
            this.ChampionSkinName.Size = new System.Drawing.Size(56, 17);
            this.ChampionSkinName.TabIndex = 14;
            this.ChampionSkinName.Text = "银色之牙";
            this.ChampionSkinName.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // ChampionName
            // 
            this.ChampionName.AutoSize = true;
            this.ChampionName.BackColor = System.Drawing.Color.Transparent;
            this.ChampionName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChampionName.ForeColor = System.Drawing.SystemColors.Control;
            this.ChampionName.Location = new System.Drawing.Point(100, 16);
            this.ChampionName.Name = "ChampionName";
            this.ChampionName.Size = new System.Drawing.Size(139, 21);
            this.ChampionName.TabIndex = 13;
            this.ChampionName.Text = "暗影之拳 - 阿卡丽";
            this.ChampionName.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // ChampionPortrait
            // 
            this.ChampionPortrait.BackColor = System.Drawing.Color.Transparent;
            this.ChampionPortrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChampionPortrait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChampionPortrait.Location = new System.Drawing.Point(14, 20);
            this.ChampionPortrait.Name = "ChampionPortrait";
            this.ChampionPortrait.Size = new System.Drawing.Size(80, 80);
            this.ChampionPortrait.TabIndex = 12;
            this.ChampionPortrait.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaxSizeBox_MouseClick);
            // 
            // preview0
            // 
            this.preview0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview0.Location = new System.Drawing.Point(0, 0);
            this.preview0.Name = "preview0";
            this.preview0.Size = new System.Drawing.Size(162, 43);
            this.preview0.TabIndex = 15;
            // 
            // SkinPreviewsPanel
            // 
            this.SkinPreviewsPanel.Controls.Add(this.preview12);
            this.SkinPreviewsPanel.Controls.Add(this.preview11);
            this.SkinPreviewsPanel.Controls.Add(this.preview10);
            this.SkinPreviewsPanel.Controls.Add(this.preview9);
            this.SkinPreviewsPanel.Controls.Add(this.preview8);
            this.SkinPreviewsPanel.Controls.Add(this.preview7);
            this.SkinPreviewsPanel.Controls.Add(this.preview0);
            this.SkinPreviewsPanel.Controls.Add(this.preview1);
            this.SkinPreviewsPanel.Controls.Add(this.preview2);
            this.SkinPreviewsPanel.Controls.Add(this.preview3);
            this.SkinPreviewsPanel.Controls.Add(this.preview4);
            this.SkinPreviewsPanel.Controls.Add(this.preview5);
            this.SkinPreviewsPanel.Controls.Add(this.preview6);
            this.SkinPreviewsPanel.Location = new System.Drawing.Point(0, 1);
            this.SkinPreviewsPanel.Name = "SkinPreviewsPanel";
            this.SkinPreviewsPanel.Size = new System.Drawing.Size(173, 657);
            this.SkinPreviewsPanel.TabIndex = 19;
            this.SkinPreviewsPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.SkinPreviewPanel_MouseWheel);
            // 
            // preview12
            // 
            this.preview12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview12.Location = new System.Drawing.Point(0, 612);
            this.preview12.Name = "preview12";
            this.preview12.Size = new System.Drawing.Size(162, 43);
            this.preview12.TabIndex = 27;
            // 
            // preview11
            // 
            this.preview11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview11.Location = new System.Drawing.Point(0, 561);
            this.preview11.Name = "preview11";
            this.preview11.Size = new System.Drawing.Size(162, 43);
            this.preview11.TabIndex = 26;
            // 
            // preview10
            // 
            this.preview10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview10.Location = new System.Drawing.Point(0, 510);
            this.preview10.Name = "preview10";
            this.preview10.Size = new System.Drawing.Size(162, 43);
            this.preview10.TabIndex = 25;
            // 
            // preview9
            // 
            this.preview9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview9.Location = new System.Drawing.Point(0, 459);
            this.preview9.Name = "preview9";
            this.preview9.Size = new System.Drawing.Size(162, 43);
            this.preview9.TabIndex = 24;
            // 
            // preview8
            // 
            this.preview8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview8.Location = new System.Drawing.Point(0, 408);
            this.preview8.Name = "preview8";
            this.preview8.Size = new System.Drawing.Size(162, 43);
            this.preview8.TabIndex = 23;
            // 
            // preview7
            // 
            this.preview7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview7.Location = new System.Drawing.Point(0, 357);
            this.preview7.Name = "preview7";
            this.preview7.Size = new System.Drawing.Size(162, 43);
            this.preview7.TabIndex = 22;
            // 
            // preview1
            // 
            this.preview1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview1.Location = new System.Drawing.Point(0, 51);
            this.preview1.Name = "preview1";
            this.preview1.Size = new System.Drawing.Size(162, 43);
            this.preview1.TabIndex = 16;
            // 
            // preview2
            // 
            this.preview2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview2.Location = new System.Drawing.Point(0, 102);
            this.preview2.Name = "preview2";
            this.preview2.Size = new System.Drawing.Size(162, 43);
            this.preview2.TabIndex = 17;
            // 
            // preview3
            // 
            this.preview3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview3.Location = new System.Drawing.Point(-1, 153);
            this.preview3.Name = "preview3";
            this.preview3.Size = new System.Drawing.Size(162, 43);
            this.preview3.TabIndex = 18;
            // 
            // preview4
            // 
            this.preview4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview4.Location = new System.Drawing.Point(0, 204);
            this.preview4.Name = "preview4";
            this.preview4.Size = new System.Drawing.Size(162, 43);
            this.preview4.TabIndex = 19;
            // 
            // preview5
            // 
            this.preview5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview5.Location = new System.Drawing.Point(0, 255);
            this.preview5.Name = "preview5";
            this.preview5.Size = new System.Drawing.Size(162, 43);
            this.preview5.TabIndex = 20;
            // 
            // preview6
            // 
            this.preview6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview6.Location = new System.Drawing.Point(0, 306);
            this.preview6.Name = "preview6";
            this.preview6.Size = new System.Drawing.Size(162, 43);
            this.preview6.TabIndex = 21;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.back24_black;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Location = new System.Drawing.Point(732, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(24, 24);
            this.BackButton.TabIndex = 20;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            this.BackButton.MouseHover += new System.EventHandler(this.BackButton_MouseEnter);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this.ListPanel);
            this.ParentPanel.Controls.Add(this.ResultListPanel);
            this.ParentPanel.Location = new System.Drawing.Point(12, 55);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(658, 400);
            this.ParentPanel.TabIndex = 21;
            // 
            // stopInput
            // 
            this.stopInput.Interval = 200;
            this.stopInput.Tick += new System.EventHandler(this.stopInput_Tick);
            // 
            // stopChecked
            // 
            this.stopChecked.Tick += new System.EventHandler(this.stopChecked_Tick);
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.about24_black;
            this.AboutButton.Location = new System.Drawing.Point(792, 9);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(24, 24);
            this.AboutButton.TabIndex = 22;
            this.AboutButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutButton_MouseClick);
            this.AboutButton.MouseEnter += new System.EventHandler(this.AboutButton_MouseEnter);
            this.AboutButton.MouseLeave += new System.EventHandler(this.AboutButton_MouseLeave);
            this.AboutButton.MouseHover += new System.EventHandler(this.AboutButton_MouseEnter);
            // 
            // SettingButton
            // 
            this.SettingButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.setting24_black;
            this.SettingButton.Location = new System.Drawing.Point(762, 9);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(24, 24);
            this.SettingButton.TabIndex = 23;
            this.SettingButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SettingButton_MouseClick);
            this.SettingButton.MouseEnter += new System.EventHandler(this.SettingButton_MouseEnter);
            this.SettingButton.MouseLeave += new System.EventHandler(this.SettingButton_MouseLeave);
            this.SettingButton.MouseHover += new System.EventHandler(this.SettingButton_MouseEnter);
            // 
            // cutBox
            // 
            this.cutBox.BackColor = System.Drawing.Color.Transparent;
            this.cutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cutBox.Location = new System.Drawing.Point(160, 35);
            this.cutBox.Name = "cutBox";
            this.cutBox.Size = new System.Drawing.Size(1, 1);
            this.cutBox.TabIndex = 24;
            this.cutBox.Visible = false;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(197, 25);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(35, 12);
            this.debugLabel.TabIndex = 25;
            this.debugLabel.Text = "debug";
            this.debugLabel.Visible = false;
            // 
            // MaxSizeBox
            // 
            this.MaxSizeBox.BackgroundImage = global::SignatureBuilder.Properties.Resources.plus;
            this.MaxSizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaxSizeBox.Location = new System.Drawing.Point(701, 9);
            this.MaxSizeBox.Name = "MaxSizeBox";
            this.MaxSizeBox.Size = new System.Drawing.Size(24, 24);
            this.MaxSizeBox.TabIndex = 0;
            this.MaxSizeBox.Visible = false;
            this.MaxSizeBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaxSizeBox_MouseClick);
            // 
            // SkinPreviewPanel
            // 
            this.SkinPreviewPanel.Controls.Add(this.SkinPreviewsPanel);
            this.SkinPreviewPanel.Location = new System.Drawing.Point(677, 56);
            this.SkinPreviewPanel.Name = "SkinPreviewPanel";
            this.SkinPreviewPanel.Size = new System.Drawing.Size(173, 402);
            this.SkinPreviewPanel.TabIndex = 26;
            this.SkinPreviewPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.SkinPreviewPanel);
            this.Controls.Add(this.MaxSizeBox);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.cutBox);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChampionPanel);
            this.Controls.Add(this.SearchFilterPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.SearchFilterPanel, 0);
            this.Controls.SetChildIndex(this.ChampionPanel, 0);
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.ParentPanel, 0);
            this.Controls.SetChildIndex(this.AboutButton, 0);
            this.Controls.SetChildIndex(this.SettingButton, 0);
            this.Controls.SetChildIndex(this.cutBox, 0);
            this.Controls.SetChildIndex(this.debugLabel, 0);
            this.Controls.SetChildIndex(this.MaxSizeBox, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.title, 0);
            this.Controls.SetChildIndex(this.titleboard, 0);
            this.Controls.SetChildIndex(this.SkinPreviewPanel, 0);
            this.SearchFilterPanel.ResumeLayout(false);
            this.SearchFilterPanel.PerformLayout();
            this.ChampionPanel.ResumeLayout(false);
            this.ChampionPanel.PerformLayout();
            this.SkinPreviewsPanel.ResumeLayout(false);
            this.ParentPanel.ResumeLayout(false);
            this.SkinPreviewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.CheckBox PusherCB;
        private System.Windows.Forms.CheckBox TankCB;
        private System.Windows.Forms.CheckBox JungleCB;
        private System.Windows.Forms.CheckBox SupportCB;
        private System.Windows.Forms.CheckBox APCB;
        private System.Windows.Forms.CheckBox ADCB;
        private System.Windows.Forms.CheckBox RangeCB;
        private System.Windows.Forms.CheckBox MeleeCB;
        private System.Windows.Forms.TextBox SearchChampionTextBox;
        private System.Windows.Forms.Panel SearchFilterPanel;
        private System.Windows.Forms.Panel ResultListPanel;
        private SignatureBuilder.Widgets.BackGroundPanelTrend ChampionPanel;
        private System.Windows.Forms.Label ChampionSkinName;
        private System.Windows.Forms.Label ChampionName;
        private SignatureBuilder.Widgets.BackGroundPanelTrend ChampionPortrait;
        private System.Windows.Forms.Panel preview0;
        private System.Windows.Forms.Panel SkinPreviewsPanel;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview7;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview6;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview5;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview4;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview3;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview2;
        private SignatureBuilder.Widgets.BackGroundPanelTrend preview1;
        private System.Windows.Forms.Panel BackButton;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Timer stopInput;
        private System.Windows.Forms.Timer stopChecked;
        private System.Windows.Forms.Panel AboutButton;
        private System.Windows.Forms.Panel SettingButton;
        private Widgets.CutBox cutBox;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Panel MaxSizeBox;
        private Widgets.BackGroundPanelTrend preview12;
        private Widgets.BackGroundPanelTrend preview11;
        private Widgets.BackGroundPanelTrend preview10;
        private Widgets.BackGroundPanelTrend preview9;
        private Widgets.BackGroundPanelTrend preview8;
        private System.Windows.Forms.Panel SkinPreviewPanel;
    }
}