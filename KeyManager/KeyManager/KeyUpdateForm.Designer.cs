namespace KeyManager
{
    partial class KeyUpdateForm
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
            BtnClose = new MaterialSkin2DotNet.Controls.MaterialButton();
            BtnUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            BtnDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            TxtRemarks = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            TxtMailAddress = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtUrl = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            TxtSortNumber = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtName = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            TxtPassword = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            TxtLoginId = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            BtnPassword = new MaterialSkin2DotNet.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnClose
            // 
            BtnClose.AutoSize = false;
            BtnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnClose.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnClose.Depth = 0;
            BtnClose.HighEmphasis = true;
            BtnClose.Icon = null;
            BtnClose.Location = new Point(509, 447);
            BtnClose.Margin = new Padding(4, 6, 4, 6);
            BtnClose.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnClose.Name = "BtnClose";
            BtnClose.NoAccentTextColor = Color.Empty;
            BtnClose.Size = new Size(120, 36);
            BtnClose.TabIndex = 16;
            BtnClose.Text = "閉じる";
            BtnClose.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Outlined;
            BtnClose.UseAccentColor = false;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.AutoSize = false;
            BtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnUpdate.Depth = 0;
            BtnUpdate.HighEmphasis = true;
            BtnUpdate.Icon = null;
            BtnUpdate.Location = new Point(154, 447);
            BtnUpdate.Margin = new Padding(4, 6, 4, 6);
            BtnUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.NoAccentTextColor = Color.Empty;
            BtnUpdate.Size = new Size(120, 36);
            BtnUpdate.TabIndex = 14;
            BtnUpdate.Text = "更新";
            BtnUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnUpdate.UseAccentColor = false;
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.AutoSize = false;
            BtnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnDelete.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnDelete.Depth = 0;
            BtnDelete.HighEmphasis = true;
            BtnDelete.Icon = null;
            BtnDelete.Location = new Point(282, 447);
            BtnDelete.Margin = new Padding(4, 6, 4, 6);
            BtnDelete.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.NoAccentTextColor = Color.Empty;
            BtnDelete.Size = new Size(120, 36);
            BtnDelete.TabIndex = 17;
            BtnDelete.Text = "削除";
            BtnDelete.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnDelete.UseAccentColor = true;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.Controls.Add(TxtRemarks, 1, 5);
            tableLayoutPanel1.Controls.Add(TxtMailAddress, 1, 2);
            tableLayoutPanel1.Controls.Add(materialLabel7, 0, 2);
            tableLayoutPanel1.Controls.Add(TxtUrl, 1, 4);
            tableLayoutPanel1.Controls.Add(TxtSortNumber, 1, 6);
            tableLayoutPanel1.Controls.Add(materialLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(materialLabel6, 0, 6);
            tableLayoutPanel1.Controls.Add(TxtName, 1, 0);
            tableLayoutPanel1.Controls.Add(TxtPassword, 1, 3);
            tableLayoutPanel1.Controls.Add(materialLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(materialLabel5, 0, 5);
            tableLayoutPanel1.Controls.Add(TxtLoginId, 1, 1);
            tableLayoutPanel1.Controls.Add(materialLabel3, 0, 3);
            tableLayoutPanel1.Controls.Add(materialLabel4, 0, 4);
            tableLayoutPanel1.Location = new Point(15, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(616, 350);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // TxtRemarks
            // 
            TxtRemarks.AnimateReadOnly = false;
            TxtRemarks.AutoCompleteMode = AutoCompleteMode.None;
            TxtRemarks.AutoCompleteSource = AutoCompleteSource.None;
            TxtRemarks.BackgroundImageLayout = ImageLayout.None;
            TxtRemarks.CharacterCasing = CharacterCasing.Normal;
            TxtRemarks.Depth = 0;
            TxtRemarks.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtRemarks.HideSelection = true;
            TxtRemarks.ImeMode = ImeMode.Hiragana;
            TxtRemarks.LeadingIcon = null;
            TxtRemarks.Location = new Point(141, 253);
            TxtRemarks.MaxLength = 255;
            TxtRemarks.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtRemarks.Name = "TxtRemarks";
            TxtRemarks.PasswordChar = '\0';
            TxtRemarks.PrefixSuffixText = null;
            TxtRemarks.ReadOnly = false;
            TxtRemarks.RightToLeft = RightToLeft.No;
            TxtRemarks.SelectedText = "";
            TxtRemarks.SelectionLength = 0;
            TxtRemarks.SelectionStart = 0;
            TxtRemarks.ShortcutsEnabled = true;
            TxtRemarks.Size = new Size(472, 48);
            TxtRemarks.TabIndex = 14;
            TxtRemarks.TabStop = false;
            TxtRemarks.TextAlign = HorizontalAlignment.Left;
            TxtRemarks.TrailingIcon = null;
            TxtRemarks.UseSystemPasswordChar = false;
            // 
            // TxtMailAddress
            // 
            TxtMailAddress.AnimateReadOnly = false;
            TxtMailAddress.AutoCompleteMode = AutoCompleteMode.None;
            TxtMailAddress.AutoCompleteSource = AutoCompleteSource.None;
            TxtMailAddress.BackgroundImageLayout = ImageLayout.None;
            TxtMailAddress.CharacterCasing = CharacterCasing.Normal;
            TxtMailAddress.Depth = 0;
            TxtMailAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtMailAddress.HideSelection = true;
            TxtMailAddress.ImeMode = ImeMode.Disable;
            TxtMailAddress.LeadingIcon = null;
            TxtMailAddress.Location = new Point(141, 103);
            TxtMailAddress.MaxLength = 255;
            TxtMailAddress.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtMailAddress.Name = "TxtMailAddress";
            TxtMailAddress.PasswordChar = '\0';
            TxtMailAddress.PrefixSuffixText = null;
            TxtMailAddress.ReadOnly = false;
            TxtMailAddress.RightToLeft = RightToLeft.No;
            TxtMailAddress.SelectedText = "";
            TxtMailAddress.SelectionLength = 0;
            TxtMailAddress.SelectionStart = 0;
            TxtMailAddress.ShortcutsEnabled = true;
            TxtMailAddress.Size = new Size(472, 48);
            TxtMailAddress.TabIndex = 20;
            TxtMailAddress.TabStop = false;
            TxtMailAddress.TextAlign = HorizontalAlignment.Left;
            TxtMailAddress.TrailingIcon = null;
            TxtMailAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(0, 100);
            materialLabel7.Margin = new Padding(0);
            materialLabel7.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(138, 50);
            materialLabel7.TabIndex = 19;
            materialLabel7.Text = "メールアドレス ： ";
            materialLabel7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtUrl
            // 
            TxtUrl.AnimateReadOnly = false;
            TxtUrl.AutoCompleteMode = AutoCompleteMode.None;
            TxtUrl.AutoCompleteSource = AutoCompleteSource.None;
            TxtUrl.BackgroundImageLayout = ImageLayout.None;
            TxtUrl.CharacterCasing = CharacterCasing.Normal;
            TxtUrl.Depth = 0;
            TxtUrl.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtUrl.HideSelection = true;
            TxtUrl.ImeMode = ImeMode.Alpha;
            TxtUrl.LeadingIcon = null;
            TxtUrl.Location = new Point(141, 203);
            TxtUrl.MaxLength = 255;
            TxtUrl.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtUrl.Name = "TxtUrl";
            TxtUrl.PasswordChar = '\0';
            TxtUrl.PrefixSuffixText = null;
            TxtUrl.ReadOnly = false;
            TxtUrl.RightToLeft = RightToLeft.No;
            TxtUrl.SelectedText = "";
            TxtUrl.SelectionLength = 0;
            TxtUrl.SelectionStart = 0;
            TxtUrl.ShortcutsEnabled = true;
            TxtUrl.Size = new Size(472, 48);
            TxtUrl.TabIndex = 13;
            TxtUrl.TabStop = false;
            TxtUrl.TextAlign = HorizontalAlignment.Left;
            TxtUrl.TrailingIcon = null;
            TxtUrl.UseSystemPasswordChar = false;
            // 
            // TxtSortNumber
            // 
            TxtSortNumber.AnimateReadOnly = false;
            TxtSortNumber.AutoCompleteMode = AutoCompleteMode.None;
            TxtSortNumber.AutoCompleteSource = AutoCompleteSource.None;
            TxtSortNumber.BackgroundImageLayout = ImageLayout.None;
            TxtSortNumber.CharacterCasing = CharacterCasing.Normal;
            TxtSortNumber.Depth = 0;
            TxtSortNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtSortNumber.HideSelection = true;
            TxtSortNumber.ImeMode = ImeMode.Disable;
            TxtSortNumber.LeadingIcon = null;
            TxtSortNumber.Location = new Point(141, 303);
            TxtSortNumber.MaxLength = 10;
            TxtSortNumber.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtSortNumber.Name = "TxtSortNumber";
            TxtSortNumber.PasswordChar = '\0';
            TxtSortNumber.PrefixSuffixText = null;
            TxtSortNumber.ReadOnly = false;
            TxtSortNumber.RightToLeft = RightToLeft.No;
            TxtSortNumber.SelectedText = "";
            TxtSortNumber.SelectionLength = 0;
            TxtSortNumber.SelectionStart = 0;
            TxtSortNumber.ShortcutsEnabled = true;
            TxtSortNumber.Size = new Size(472, 48);
            TxtSortNumber.TabIndex = 16;
            TxtSortNumber.TabStop = false;
            TxtSortNumber.TextAlign = HorizontalAlignment.Left;
            TxtSortNumber.TrailingIcon = null;
            TxtSortNumber.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(0, 0);
            materialLabel1.Margin = new Padding(0);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(138, 50);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "名称 ： ";
            materialLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(0, 300);
            materialLabel6.Margin = new Padding(0);
            materialLabel6.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(138, 50);
            materialLabel6.TabIndex = 15;
            materialLabel6.Text = "ソートNo ： ";
            materialLabel6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtName
            // 
            TxtName.AnimateReadOnly = false;
            TxtName.AutoCompleteMode = AutoCompleteMode.None;
            TxtName.AutoCompleteSource = AutoCompleteSource.None;
            TxtName.BackgroundImageLayout = ImageLayout.None;
            TxtName.CharacterCasing = CharacterCasing.Normal;
            TxtName.Depth = 0;
            TxtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtName.HideSelection = true;
            TxtName.ImeMode = ImeMode.Hiragana;
            TxtName.LeadingIcon = null;
            TxtName.Location = new Point(141, 3);
            TxtName.MaxLength = 255;
            TxtName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtName.Name = "TxtName";
            TxtName.PasswordChar = '\0';
            TxtName.PrefixSuffixText = null;
            TxtName.ReadOnly = false;
            TxtName.RightToLeft = RightToLeft.No;
            TxtName.SelectedText = "";
            TxtName.SelectionLength = 0;
            TxtName.SelectionStart = 0;
            TxtName.ShortcutsEnabled = true;
            TxtName.Size = new Size(472, 48);
            TxtName.TabIndex = 10;
            TxtName.TabStop = false;
            TxtName.TextAlign = HorizontalAlignment.Left;
            TxtName.TrailingIcon = null;
            TxtName.UseSystemPasswordChar = false;
            // 
            // TxtPassword
            // 
            TxtPassword.AnimateReadOnly = false;
            TxtPassword.AutoCompleteMode = AutoCompleteMode.None;
            TxtPassword.AutoCompleteSource = AutoCompleteSource.None;
            TxtPassword.BackgroundImageLayout = ImageLayout.None;
            TxtPassword.CharacterCasing = CharacterCasing.Normal;
            TxtPassword.Depth = 0;
            TxtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtPassword.HideSelection = true;
            TxtPassword.ImeMode = ImeMode.Alpha;
            TxtPassword.LeadingIcon = null;
            TxtPassword.Location = new Point(141, 153);
            TxtPassword.MaxLength = 255;
            TxtPassword.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '\0';
            TxtPassword.PrefixSuffixText = null;
            TxtPassword.ReadOnly = false;
            TxtPassword.RightToLeft = RightToLeft.No;
            TxtPassword.SelectedText = "";
            TxtPassword.SelectionLength = 0;
            TxtPassword.SelectionStart = 0;
            TxtPassword.ShortcutsEnabled = true;
            TxtPassword.Size = new Size(472, 48);
            TxtPassword.TabIndex = 12;
            TxtPassword.TabStop = false;
            TxtPassword.TextAlign = HorizontalAlignment.Left;
            TxtPassword.TrailingIcon = null;
            TxtPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(0, 50);
            materialLabel2.Margin = new Padding(0);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(138, 50);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "ログインID ： ";
            materialLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(0, 250);
            materialLabel5.Margin = new Padding(0);
            materialLabel5.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(138, 50);
            materialLabel5.TabIndex = 6;
            materialLabel5.Text = "備考 ： ";
            materialLabel5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtLoginId
            // 
            TxtLoginId.AnimateReadOnly = false;
            TxtLoginId.AutoCompleteMode = AutoCompleteMode.None;
            TxtLoginId.AutoCompleteSource = AutoCompleteSource.None;
            TxtLoginId.BackgroundImageLayout = ImageLayout.None;
            TxtLoginId.CharacterCasing = CharacterCasing.Normal;
            TxtLoginId.Depth = 0;
            TxtLoginId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtLoginId.HideSelection = true;
            TxtLoginId.ImeMode = ImeMode.Alpha;
            TxtLoginId.LeadingIcon = null;
            TxtLoginId.Location = new Point(141, 53);
            TxtLoginId.MaxLength = 255;
            TxtLoginId.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            TxtLoginId.Name = "TxtLoginId";
            TxtLoginId.PasswordChar = '\0';
            TxtLoginId.PrefixSuffixText = null;
            TxtLoginId.ReadOnly = false;
            TxtLoginId.RightToLeft = RightToLeft.No;
            TxtLoginId.SelectedText = "";
            TxtLoginId.SelectionLength = 0;
            TxtLoginId.SelectionStart = 0;
            TxtLoginId.ShortcutsEnabled = true;
            TxtLoginId.Size = new Size(472, 48);
            TxtLoginId.TabIndex = 11;
            TxtLoginId.TabStop = false;
            TxtLoginId.TextAlign = HorizontalAlignment.Left;
            TxtLoginId.TrailingIcon = null;
            TxtLoginId.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(0, 150);
            materialLabel3.Margin = new Padding(0);
            materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(138, 50);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "パスワード ： ";
            materialLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(0, 200);
            materialLabel4.Margin = new Padding(0);
            materialLabel4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(138, 50);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "URL ： ";
            materialLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnPassword
            // 
            BtnPassword.AutoSize = false;
            BtnPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnPassword.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnPassword.Depth = 0;
            BtnPassword.HighEmphasis = true;
            BtnPassword.Icon = null;
            BtnPassword.Location = new Point(654, 239);
            BtnPassword.Margin = new Padding(4, 6, 4, 6);
            BtnPassword.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnPassword.Name = "BtnPassword";
            BtnPassword.NoAccentTextColor = Color.Empty;
            BtnPassword.Size = new Size(120, 36);
            BtnPassword.TabIndex = 19;
            BtnPassword.Text = "生成";
            BtnPassword.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnPassword.UseAccentColor = false;
            BtnPassword.UseVisualStyleBackColor = true;
            BtnPassword.Click += BtnPassword_Click;
            // 
            // KeyUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(BtnPassword);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BtnDelete);
            Controls.Add(BtnClose);
            Controls.Add(BtnUpdate);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KeyUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "変更";
            Load += KeyUpdateForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton BtnClose;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnUpdate;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnDelete;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtRemarks;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtUrl;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtPassword;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtLoginId;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtName;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel5;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel6;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtSortNumber;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtMailAddress;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel7;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnPassword;
    }
}