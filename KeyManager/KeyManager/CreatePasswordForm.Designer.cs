namespace KeyManager
{
    partial class CreatePasswordForm
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
            BtnEnter = new MaterialSkin2DotNet.Controls.MaterialButton();
            BtnClose = new MaterialSkin2DotNet.Controls.MaterialButton();
            LstPassword = new MaterialSkin2DotNet.Controls.MaterialListView();
            ColPassword = new ColumnHeader();
            ChkNumbers = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            RdbCharLen8 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            groupBox1 = new GroupBox();
            ChkSymbols = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            ChkLowercase = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            ChkUppercase = new MaterialSkin2DotNet.Controls.MaterialCheckbox();
            groupBox2 = new GroupBox();
            TxtCharLen = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            RdbCharLenN = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            RdbCharLen16 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            RdbCharLen12 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            groupBox3 = new GroupBox();
            RdbCount30 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            RdbCount10 = new MaterialSkin2DotNet.Controls.MaterialRadioButton();
            BtnCreate = new MaterialSkin2DotNet.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BtnEnter
            // 
            BtnEnter.AutoSize = false;
            BtnEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnEnter.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnEnter.Depth = 0;
            BtnEnter.HighEmphasis = true;
            BtnEnter.Icon = null;
            BtnEnter.Location = new Point(287, 619);
            BtnEnter.Margin = new Padding(4, 7, 4, 7);
            BtnEnter.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnEnter.Name = "BtnEnter";
            BtnEnter.NoAccentTextColor = Color.Empty;
            BtnEnter.Size = new Size(177, 41);
            BtnEnter.TabIndex = 15;
            BtnEnter.Text = "決  定";
            BtnEnter.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnEnter.UseAccentColor = false;
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // BtnClose
            // 
            BtnClose.AutoSize = false;
            BtnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnClose.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnClose.Depth = 0;
            BtnClose.HighEmphasis = true;
            BtnClose.Icon = null;
            BtnClose.Location = new Point(487, 619);
            BtnClose.Margin = new Padding(4, 7, 4, 7);
            BtnClose.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnClose.Name = "BtnClose";
            BtnClose.NoAccentTextColor = Color.Empty;
            BtnClose.Size = new Size(120, 41);
            BtnClose.TabIndex = 16;
            BtnClose.Text = "閉じる";
            BtnClose.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnClose.UseAccentColor = false;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // LstPassword
            // 
            LstPassword.AutoSizeTable = false;
            LstPassword.BackColor = Color.FromArgb(255, 255, 255);
            LstPassword.BorderStyle = BorderStyle.None;
            LstPassword.Columns.AddRange(new ColumnHeader[] { ColPassword });
            LstPassword.Depth = 0;
            LstPassword.FullRowSelect = true;
            LstPassword.Location = new Point(287, 141);
            LstPassword.MinimumSize = new Size(200, 113);
            LstPassword.MouseLocation = new Point(-1, -1);
            LstPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            LstPassword.Name = "LstPassword";
            LstPassword.OwnerDraw = true;
            LstPassword.Size = new Size(320, 457);
            LstPassword.TabIndex = 17;
            LstPassword.UseCompatibleStateImageBehavior = false;
            LstPassword.View = View.Details;
            // 
            // ColPassword
            // 
            ColPassword.Text = "パスワード";
            ColPassword.Width = 300;
            // 
            // ChkNumbers
            // 
            ChkNumbers.Checked = true;
            ChkNumbers.CheckState = CheckState.Checked;
            ChkNumbers.Depth = 0;
            ChkNumbers.Location = new Point(3, 23);
            ChkNumbers.Margin = new Padding(0);
            ChkNumbers.MouseLocation = new Point(-1, -1);
            ChkNumbers.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            ChkNumbers.Name = "ChkNumbers";
            ChkNumbers.ReadOnly = false;
            ChkNumbers.Ripple = true;
            ChkNumbers.Size = new Size(242, 42);
            ChkNumbers.TabIndex = 18;
            ChkNumbers.Text = "数字を使用する";
            ChkNumbers.UseVisualStyleBackColor = true;
            // 
            // RdbCharLen8
            // 
            RdbCharLen8.Depth = 0;
            RdbCharLen8.Location = new Point(3, 21);
            RdbCharLen8.Margin = new Padding(0);
            RdbCharLen8.MouseLocation = new Point(-1, -1);
            RdbCharLen8.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            RdbCharLen8.Name = "RdbCharLen8";
            RdbCharLen8.Ripple = true;
            RdbCharLen8.Size = new Size(242, 42);
            RdbCharLen8.TabIndex = 19;
            RdbCharLen8.TabStop = true;
            RdbCharLen8.Text = "8文字";
            RdbCharLen8.UseVisualStyleBackColor = true;
            RdbCharLen8.CheckedChanged += RdbCharLenN_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChkSymbols);
            groupBox1.Controls.Add(ChkLowercase);
            groupBox1.Controls.Add(ChkUppercase);
            groupBox1.Controls.Add(ChkNumbers);
            groupBox1.Location = new Point(19, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 195);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "使用文字";
            // 
            // ChkSymbols
            // 
            ChkSymbols.Depth = 0;
            ChkSymbols.Location = new Point(3, 149);
            ChkSymbols.Margin = new Padding(0);
            ChkSymbols.MouseLocation = new Point(-1, -1);
            ChkSymbols.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            ChkSymbols.Name = "ChkSymbols";
            ChkSymbols.ReadOnly = false;
            ChkSymbols.Ripple = true;
            ChkSymbols.Size = new Size(242, 37);
            ChkSymbols.TabIndex = 21;
            ChkSymbols.Text = "記号を使用する";
            ChkSymbols.UseVisualStyleBackColor = true;
            // 
            // ChkLowercase
            // 
            ChkLowercase.Checked = true;
            ChkLowercase.CheckState = CheckState.Checked;
            ChkLowercase.Depth = 0;
            ChkLowercase.Location = new Point(3, 107);
            ChkLowercase.Margin = new Padding(0);
            ChkLowercase.MouseLocation = new Point(-1, -1);
            ChkLowercase.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            ChkLowercase.Name = "ChkLowercase";
            ChkLowercase.ReadOnly = false;
            ChkLowercase.Ripple = true;
            ChkLowercase.Size = new Size(242, 37);
            ChkLowercase.TabIndex = 20;
            ChkLowercase.Text = "アルファベット小文字を使用する";
            ChkLowercase.UseVisualStyleBackColor = true;
            // 
            // ChkUppercase
            // 
            ChkUppercase.Checked = true;
            ChkUppercase.CheckState = CheckState.Checked;
            ChkUppercase.Depth = 0;
            ChkUppercase.Location = new Point(3, 65);
            ChkUppercase.Margin = new Padding(0);
            ChkUppercase.MouseLocation = new Point(-1, -1);
            ChkUppercase.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            ChkUppercase.Name = "ChkUppercase";
            ChkUppercase.ReadOnly = false;
            ChkUppercase.Ripple = true;
            ChkUppercase.Size = new Size(242, 37);
            ChkUppercase.TabIndex = 19;
            ChkUppercase.Text = "アルファベット大文字を使用する";
            ChkUppercase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtCharLen);
            groupBox2.Controls.Add(RdbCharLenN);
            groupBox2.Controls.Add(RdbCharLen16);
            groupBox2.Controls.Add(RdbCharLen12);
            groupBox2.Controls.Add(RdbCharLen8);
            groupBox2.Location = new Point(19, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 256);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "文字数";
            // 
            // TxtCharLen
            // 
            TxtCharLen.AnimateReadOnly = false;
            TxtCharLen.AutoCompleteMode = AutoCompleteMode.None;
            TxtCharLen.AutoCompleteSource = AutoCompleteSource.None;
            TxtCharLen.BackgroundImageLayout = ImageLayout.None;
            TxtCharLen.CharacterCasing = CharacterCasing.Normal;
            TxtCharLen.Depth = 0;
            TxtCharLen.Enabled = false;
            TxtCharLen.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtCharLen.HideSelection = true;
            TxtCharLen.LeadingIcon = null;
            TxtCharLen.Location = new Point(37, 202);
            TxtCharLen.MaxLength = 4;
            TxtCharLen.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtCharLen.Name = "TxtCharLen";
            TxtCharLen.PasswordChar = '\0';
            TxtCharLen.PrefixSuffixText = null;
            TxtCharLen.ReadOnly = false;
            TxtCharLen.RightToLeft = RightToLeft.No;
            TxtCharLen.SelectedText = "";
            TxtCharLen.SelectionLength = 0;
            TxtCharLen.SelectionStart = 0;
            TxtCharLen.ShortcutsEnabled = true;
            TxtCharLen.Size = new Size(197, 48);
            TxtCharLen.TabIndex = 23;
            TxtCharLen.TabStop = false;
            TxtCharLen.TextAlign = HorizontalAlignment.Left;
            TxtCharLen.TrailingIcon = null;
            TxtCharLen.UseSystemPasswordChar = false;
            // 
            // RdbCharLenN
            // 
            RdbCharLenN.Depth = 0;
            RdbCharLenN.Location = new Point(3, 156);
            RdbCharLenN.Margin = new Padding(0);
            RdbCharLenN.MouseLocation = new Point(-1, -1);
            RdbCharLenN.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            RdbCharLenN.Name = "RdbCharLenN";
            RdbCharLenN.Ripple = true;
            RdbCharLenN.Size = new Size(242, 42);
            RdbCharLenN.TabIndex = 22;
            RdbCharLenN.TabStop = true;
            RdbCharLenN.Text = "n文字";
            RdbCharLenN.UseVisualStyleBackColor = true;
            RdbCharLenN.CheckedChanged += RdbCharLenN_CheckedChanged;
            // 
            // RdbCharLen16
            // 
            RdbCharLen16.Checked = true;
            RdbCharLen16.Depth = 0;
            RdbCharLen16.Location = new Point(3, 111);
            RdbCharLen16.Margin = new Padding(0);
            RdbCharLen16.MouseLocation = new Point(-1, -1);
            RdbCharLen16.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            RdbCharLen16.Name = "RdbCharLen16";
            RdbCharLen16.Ripple = true;
            RdbCharLen16.Size = new Size(242, 42);
            RdbCharLen16.TabIndex = 21;
            RdbCharLen16.TabStop = true;
            RdbCharLen16.Text = "16文字";
            RdbCharLen16.UseVisualStyleBackColor = true;
            RdbCharLen16.CheckedChanged += RdbCharLenN_CheckedChanged;
            // 
            // RdbCharLen12
            // 
            RdbCharLen12.Depth = 0;
            RdbCharLen12.Location = new Point(3, 66);
            RdbCharLen12.Margin = new Padding(0);
            RdbCharLen12.MouseLocation = new Point(-1, -1);
            RdbCharLen12.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            RdbCharLen12.Name = "RdbCharLen12";
            RdbCharLen12.Ripple = true;
            RdbCharLen12.Size = new Size(242, 42);
            RdbCharLen12.TabIndex = 20;
            RdbCharLen12.TabStop = true;
            RdbCharLen12.Text = "12文字";
            RdbCharLen12.UseVisualStyleBackColor = true;
            RdbCharLen12.CheckedChanged += RdbCharLenN_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RdbCount30);
            groupBox3.Controls.Add(RdbCount10);
            groupBox3.Location = new Point(19, 540);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(248, 120);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "生成個数";
            // 
            // RdbCount30
            // 
            RdbCount30.Depth = 0;
            RdbCount30.Location = new Point(3, 70);
            RdbCount30.Margin = new Padding(0);
            RdbCount30.MouseLocation = new Point(-1, -1);
            RdbCount30.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            RdbCount30.Name = "RdbCount30";
            RdbCount30.Ripple = true;
            RdbCount30.Size = new Size(242, 42);
            RdbCount30.TabIndex = 22;
            RdbCount30.TabStop = true;
            RdbCount30.Text = "30個";
            RdbCount30.UseVisualStyleBackColor = true;
            // 
            // RdbCount10
            // 
            RdbCount10.Checked = true;
            RdbCount10.Depth = 0;
            RdbCount10.Location = new Point(3, 25);
            RdbCount10.Margin = new Padding(0);
            RdbCount10.MouseLocation = new Point(-1, -1);
            RdbCount10.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            RdbCount10.Name = "RdbCount10";
            RdbCount10.Ripple = true;
            RdbCount10.Size = new Size(242, 42);
            RdbCount10.TabIndex = 21;
            RdbCount10.TabStop = true;
            RdbCount10.Text = "10個";
            RdbCount10.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            BtnCreate.AutoSize = false;
            BtnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCreate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnCreate.Depth = 0;
            BtnCreate.HighEmphasis = true;
            BtnCreate.Icon = null;
            BtnCreate.Location = new Point(287, 80);
            BtnCreate.Margin = new Padding(4, 7, 4, 7);
            BtnCreate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnCreate.Name = "BtnCreate";
            BtnCreate.NoAccentTextColor = Color.Empty;
            BtnCreate.Size = new Size(320, 36);
            BtnCreate.TabIndex = 23;
            BtnCreate.Text = "パスワード生成";
            BtnCreate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnCreate.UseAccentColor = true;
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // CreatePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 678);
            Controls.Add(BtnCreate);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(LstPassword);
            Controls.Add(BtnClose);
            Controls.Add(BtnEnter);
            Font = new Font("Noto Sans JP", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreatePasswordForm";
            Padding = new Padding(3, 73, 3, 3);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "パスワード生成";
            Load += FrmCreatePassword_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton BtnEnter;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnClose;
        private MaterialSkin2DotNet.Controls.MaterialListView LstPassword;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox ChkNumbers;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdbCharLen8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox ChkSymbols;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox ChkLowercase;
        private MaterialSkin2DotNet.Controls.MaterialCheckbox ChkUppercase;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtCharLen;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdbCharLenN;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdbCharLen16;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdbCharLen12;
        private ColumnHeader ColPassword;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdbCount30;
        private MaterialSkin2DotNet.Controls.MaterialRadioButton RdbCount10;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnCreate;
    }
}