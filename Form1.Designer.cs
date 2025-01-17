namespace Calculator2._0
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            MiddlePanel = new Panel();
            TxtBox = new TextBox();
            LowPanel = new Panel();
            EqualBtn = new Button();
            DecimalBtn = new Button();
            ZeroBtn = new Button();
            ChangeSignBtn = new Button();
            MultiplyBtn = new Button();
            SubtractBtn = new Button();
            ThreeBtn = new Button();
            TwoBtn = new Button();
            OneBtn = new Button();
            DivideBtn = new Button();
            AddBtn = new Button();
            SixBtn = new Button();
            FiveBtn = new Button();
            FourBtn = new Button();
            BackspaceBtn = new Button();
            ClearBtn = new Button();
            NineBtn = new Button();
            EightBtn = new Button();
            SevenBtn = new Button();
            TopPanel = new Panel();
            CloseBtn = new Button();
            MainTitle = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            MiddlePanel.SuspendLayout();
            LowPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MiddlePanel
            // 
            MiddlePanel.BackColor = Color.PaleVioletRed;
            MiddlePanel.BorderStyle = BorderStyle.Fixed3D;
            MiddlePanel.Controls.Add(TxtBox);
            MiddlePanel.Font = new Font("Arial", 20F, FontStyle.Bold);
            MiddlePanel.Location = new Point(9, 72);
            MiddlePanel.Margin = new Padding(0);
            MiddlePanel.Name = "MiddlePanel";
            MiddlePanel.Size = new Size(547, 212);
            MiddlePanel.TabIndex = 0;
            // 
            // TxtBox
            // 
            TxtBox.BackColor = Color.LavenderBlush;
            TxtBox.BorderStyle = BorderStyle.FixedSingle;
            TxtBox.Font = new Font("Arial", 25F, FontStyle.Bold);
            TxtBox.Location = new Point(15, 38);
            TxtBox.Margin = new Padding(0);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.ScrollBars = ScrollBars.Vertical;
            TxtBox.ShortcutsEnabled = false;
            TxtBox.Size = new Size(514, 133);
            TxtBox.TabIndex = 0;
            TxtBox.TabStop = false;
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.UseWaitCursor = true;
            // 
            // LowPanel
            // 
            LowPanel.BackColor = Color.PaleVioletRed;
            LowPanel.BorderStyle = BorderStyle.Fixed3D;
            LowPanel.Controls.Add(EqualBtn);
            LowPanel.Controls.Add(DecimalBtn);
            LowPanel.Controls.Add(ZeroBtn);
            LowPanel.Controls.Add(ChangeSignBtn);
            LowPanel.Controls.Add(MultiplyBtn);
            LowPanel.Controls.Add(SubtractBtn);
            LowPanel.Controls.Add(ThreeBtn);
            LowPanel.Controls.Add(TwoBtn);
            LowPanel.Controls.Add(OneBtn);
            LowPanel.Controls.Add(DivideBtn);
            LowPanel.Controls.Add(AddBtn);
            LowPanel.Controls.Add(SixBtn);
            LowPanel.Controls.Add(FiveBtn);
            LowPanel.Controls.Add(FourBtn);
            LowPanel.Controls.Add(BackspaceBtn);
            LowPanel.Controls.Add(ClearBtn);
            LowPanel.Controls.Add(NineBtn);
            LowPanel.Controls.Add(EightBtn);
            LowPanel.Controls.Add(SevenBtn);
            LowPanel.Font = new Font("Arial", 20F, FontStyle.Bold);
            LowPanel.Location = new Point(9, 330);
            LowPanel.Margin = new Padding(0);
            LowPanel.Name = "LowPanel";
            LowPanel.Size = new Size(547, 435);
            LowPanel.TabIndex = 1;
            // 
            // EqualBtn
            // 
            EqualBtn.BackColor = Color.Pink;
            EqualBtn.FlatAppearance.BorderSize = 0;
            EqualBtn.FlatStyle = FlatStyle.Popup;
            EqualBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            EqualBtn.ForeColor = Color.Black;
            EqualBtn.Location = new Point(337, 326);
            EqualBtn.Margin = new Padding(0);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(192, 90);
            EqualBtn.TabIndex = 24;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = false;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // DecimalBtn
            // 
            DecimalBtn.BackColor = Color.LavenderBlush;
            DecimalBtn.FlatAppearance.BorderSize = 0;
            DecimalBtn.FlatStyle = FlatStyle.Popup;
            DecimalBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            DecimalBtn.Location = new Point(220, 326);
            DecimalBtn.Margin = new Padding(0);
            DecimalBtn.Name = "DecimalBtn";
            DecimalBtn.Size = new Size(90, 90);
            DecimalBtn.TabIndex = 22;
            DecimalBtn.Text = ".";
            DecimalBtn.UseVisualStyleBackColor = false;
            DecimalBtn.Click += DecimalBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.BackColor = Color.HotPink;
            ZeroBtn.FlatAppearance.BorderSize = 0;
            ZeroBtn.FlatStyle = FlatStyle.Popup;
            ZeroBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            ZeroBtn.ForeColor = Color.White;
            ZeroBtn.Location = new Point(118, 326);
            ZeroBtn.Margin = new Padding(0);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(90, 90);
            ZeroBtn.TabIndex = 21;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = false;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // ChangeSignBtn
            // 
            ChangeSignBtn.BackColor = Color.LavenderBlush;
            ChangeSignBtn.FlatAppearance.BorderSize = 0;
            ChangeSignBtn.FlatStyle = FlatStyle.Popup;
            ChangeSignBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            ChangeSignBtn.Location = new Point(14, 326);
            ChangeSignBtn.Margin = new Padding(0);
            ChangeSignBtn.Name = "ChangeSignBtn";
            ChangeSignBtn.Size = new Size(90, 90);
            ChangeSignBtn.TabIndex = 20;
            ChangeSignBtn.Text = "+/-";
            ChangeSignBtn.UseVisualStyleBackColor = false;
            ChangeSignBtn.Click += ChangeSignBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.BackColor = Color.LavenderBlush;
            MultiplyBtn.FlatAppearance.BorderSize = 0;
            MultiplyBtn.FlatStyle = FlatStyle.Popup;
            MultiplyBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            MultiplyBtn.Location = new Point(439, 223);
            MultiplyBtn.Margin = new Padding(0);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(90, 90);
            MultiplyBtn.TabIndex = 19;
            MultiplyBtn.Text = "*";
            MultiplyBtn.UseVisualStyleBackColor = false;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // SubtractBtn
            // 
            SubtractBtn.BackColor = Color.LavenderBlush;
            SubtractBtn.FlatAppearance.BorderSize = 0;
            SubtractBtn.FlatStyle = FlatStyle.Popup;
            SubtractBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            SubtractBtn.Location = new Point(337, 223);
            SubtractBtn.Margin = new Padding(0);
            SubtractBtn.Name = "SubtractBtn";
            SubtractBtn.Size = new Size(90, 90);
            SubtractBtn.TabIndex = 18;
            SubtractBtn.Text = "-";
            SubtractBtn.UseVisualStyleBackColor = false;
            SubtractBtn.Click += SubtractBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.BackColor = Color.HotPink;
            ThreeBtn.FlatAppearance.BorderSize = 0;
            ThreeBtn.FlatStyle = FlatStyle.Popup;
            ThreeBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            ThreeBtn.ForeColor = Color.White;
            ThreeBtn.Location = new Point(220, 223);
            ThreeBtn.Margin = new Padding(0);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(90, 90);
            ThreeBtn.TabIndex = 17;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = false;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.BackColor = Color.HotPink;
            TwoBtn.FlatAppearance.BorderSize = 0;
            TwoBtn.FlatStyle = FlatStyle.Popup;
            TwoBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            TwoBtn.ForeColor = Color.White;
            TwoBtn.Location = new Point(118, 223);
            TwoBtn.Margin = new Padding(0);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(90, 90);
            TwoBtn.TabIndex = 16;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = false;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.BackColor = Color.HotPink;
            OneBtn.FlatAppearance.BorderSize = 0;
            OneBtn.FlatStyle = FlatStyle.Popup;
            OneBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            OneBtn.ForeColor = Color.White;
            OneBtn.Location = new Point(15, 223);
            OneBtn.Margin = new Padding(0);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(90, 90);
            OneBtn.TabIndex = 15;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = false;
            OneBtn.Click += OneBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.BackColor = Color.LavenderBlush;
            DivideBtn.FlatAppearance.BorderSize = 0;
            DivideBtn.FlatStyle = FlatStyle.Popup;
            DivideBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            DivideBtn.Location = new Point(439, 118);
            DivideBtn.Margin = new Padding(0);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(90, 90);
            DivideBtn.TabIndex = 14;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = false;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LavenderBlush;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Popup;
            AddBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            AddBtn.Location = new Point(337, 118);
            AddBtn.Margin = new Padding(0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(90, 90);
            AddBtn.TabIndex = 13;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.BackColor = Color.HotPink;
            SixBtn.FlatAppearance.BorderSize = 0;
            SixBtn.FlatStyle = FlatStyle.Popup;
            SixBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            SixBtn.ForeColor = Color.White;
            SixBtn.Location = new Point(220, 118);
            SixBtn.Margin = new Padding(0);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(90, 90);
            SixBtn.TabIndex = 12;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = false;
            SixBtn.Click += SixBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.BackColor = Color.HotPink;
            FiveBtn.FlatAppearance.BorderSize = 0;
            FiveBtn.FlatStyle = FlatStyle.Popup;
            FiveBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            FiveBtn.ForeColor = Color.White;
            FiveBtn.Location = new Point(118, 118);
            FiveBtn.Margin = new Padding(0);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(90, 90);
            FiveBtn.TabIndex = 11;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = false;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.BackColor = Color.HotPink;
            FourBtn.FlatAppearance.BorderSize = 0;
            FourBtn.FlatStyle = FlatStyle.Popup;
            FourBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            FourBtn.ForeColor = Color.White;
            FourBtn.Location = new Point(15, 118);
            FourBtn.Margin = new Padding(0);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(90, 90);
            FourBtn.TabIndex = 10;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = false;
            FourBtn.Click += FourBtn_Click;
            // 
            // BackspaceBtn
            // 
            BackspaceBtn.BackColor = Color.LavenderBlush;
            BackspaceBtn.BackgroundImageLayout = ImageLayout.None;
            BackspaceBtn.FlatAppearance.BorderSize = 0;
            BackspaceBtn.FlatStyle = FlatStyle.Popup;
            BackspaceBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            BackspaceBtn.Location = new Point(439, 15);
            BackspaceBtn.Margin = new Padding(0);
            BackspaceBtn.Name = "BackspaceBtn";
            BackspaceBtn.RightToLeft = RightToLeft.No;
            BackspaceBtn.Size = new Size(90, 90);
            BackspaceBtn.TabIndex = 9;
            BackspaceBtn.Text = "←";
            BackspaceBtn.UseVisualStyleBackColor = false;
            BackspaceBtn.Click += BackspaceBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.DeepPink;
            ClearBtn.FlatAppearance.BorderSize = 0;
            ClearBtn.FlatStyle = FlatStyle.Popup;
            ClearBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            ClearBtn.ForeColor = Color.White;
            ClearBtn.Location = new Point(337, 15);
            ClearBtn.Margin = new Padding(0);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(90, 90);
            ClearBtn.TabIndex = 8;
            ClearBtn.Text = "C";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.BackColor = Color.HotPink;
            NineBtn.FlatAppearance.BorderSize = 0;
            NineBtn.FlatStyle = FlatStyle.Popup;
            NineBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            NineBtn.ForeColor = Color.White;
            NineBtn.Location = new Point(220, 15);
            NineBtn.Margin = new Padding(0);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(90, 90);
            NineBtn.TabIndex = 7;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = false;
            NineBtn.Click += NineBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.BackColor = Color.HotPink;
            EightBtn.FlatAppearance.BorderSize = 0;
            EightBtn.FlatStyle = FlatStyle.Popup;
            EightBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            EightBtn.ForeColor = Color.White;
            EightBtn.Location = new Point(118, 15);
            EightBtn.Margin = new Padding(0);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(90, 90);
            EightBtn.TabIndex = 6;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = false;
            EightBtn.Click += EightBtn_Click;
            // 
            // SevenBtn
            // 
            SevenBtn.BackColor = Color.HotPink;
            SevenBtn.FlatAppearance.BorderSize = 0;
            SevenBtn.FlatStyle = FlatStyle.Popup;
            SevenBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            SevenBtn.ForeColor = Color.White;
            SevenBtn.Location = new Point(15, 15);
            SevenBtn.Margin = new Padding(0);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(90, 90);
            SevenBtn.TabIndex = 5;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = false;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Transparent;
            TopPanel.Controls.Add(CloseBtn);
            TopPanel.Font = new Font("Arial", 20F, FontStyle.Bold);
            TopPanel.Location = new Point(495, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(71, 69);
            TopPanel.TabIndex = 2;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.BackgroundImageLayout = ImageLayout.None;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatAppearance.MouseDownBackColor = Color.White;
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.HotPink;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Arial Narrow", 15F);
            CloseBtn.Location = new Point(17, 9);
            CloseBtn.Margin = new Padding(0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.RightToLeft = RightToLeft.No;
            CloseBtn.Size = new Size(45, 42);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "×";
            CloseBtn.TextAlign = ContentAlignment.TopCenter;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MainTitle
            // 
            MainTitle.BackColor = Color.LightPink;
            MainTitle.BorderStyle = BorderStyle.None;
            MainTitle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainTitle.Location = new Point(75, 24);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(308, 28);
            MainTitle.TabIndex = 3;
            MainTitle.Text = "Calculator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(566, 800);
            Controls.Add(pictureBox1);
            Controls.Add(MainTitle);
            Controls.Add(TopPanel);
            Controls.Add(LowPanel);
            Controls.Add(MiddlePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Calculator_Load;
            MiddlePanel.ResumeLayout(false);
            MiddlePanel.PerformLayout();
            LowPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MiddlePanel;
        private Panel LowPanel;
        private TextBox TxtBox;
        private Button EqualBtn;
        private Button Decimal;
        private Button ZeroBtn;
        private Button ChangeSignBtn;
        private Button MultiplyBtn;
        private Button SubtractBtn;
        private Button ThreeBtn;
        private Button TwoBtn;
        private Button OneBtn;
        private Button DivideBtn;
        private Button AddBtn;
        private Button SixBtn;
        private Button FiveBtn;
        private Button FourBtn;
        private Button ClearBtn;
        private Button NineBtn;
        private Button EightBtn;
        private Button SevenBtn;
        private Panel TopPanel;
        private Button CloseBtn;
        private Button BackspaceBtn;
        private Button DecimalBtn;
        private TextBox MainTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
    }
}
