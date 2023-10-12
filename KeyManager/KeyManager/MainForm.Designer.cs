namespace KeyManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableKeyData = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SortNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSearchWord = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnKeyUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.BtnKeyAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableKeyData)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableKeyData
            // 
            this.TableKeyData.AllowUserToAddRows = false;
            this.TableKeyData.AllowUserToDeleteRows = false;
            this.TableKeyData.AllowUserToResizeRows = false;
            this.TableKeyData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableKeyData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TableKeyData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableKeyData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableKeyData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.TableKeyData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableKeyData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableKeyData.ColumnHeadersHeight = 56;
            this.TableKeyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableKeyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Name,
            this.Col_LoginID,
            this.Col_MailAddress,
            this.Col_Password,
            this.Col_URL,
            this.Col_Remarks,
            this.Col_SortNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableKeyData.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableKeyData.Depth = 0;
            this.TableKeyData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TableKeyData.EnableHeadersVisualStyles = false;
            this.TableKeyData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TableKeyData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TableKeyData.Location = new System.Drawing.Point(6, 60);
            this.TableKeyData.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.TableKeyData.Name = "TableKeyData";
            this.TableKeyData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableKeyData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableKeyData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TableKeyData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TableKeyData.RowTemplate.Height = 52;
            this.TableKeyData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TableKeyData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableKeyData.ShowVerticalScroll = false;
            this.TableKeyData.Size = new System.Drawing.Size(1367, 526);
            this.TableKeyData.TabIndex = 0;
            this.TableKeyData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableKeyData_CellContentClick);
            // 
            // Col_ID
            // 
            this.Col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.ReadOnly = true;
            this.Col_ID.Visible = false;
            // 
            // Col_Name
            // 
            this.Col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Name.HeaderText = "名称";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            this.Col_Name.Width = 220;
            // 
            // Col_LoginID
            // 
            this.Col_LoginID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_LoginID.HeaderText = "ログインID";
            this.Col_LoginID.Name = "Col_LoginID";
            this.Col_LoginID.ReadOnly = true;
            this.Col_LoginID.Width = 200;
            // 
            // Col_MailAddress
            // 
            this.Col_MailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_MailAddress.HeaderText = "メールアドレス";
            this.Col_MailAddress.Name = "Col_MailAddress";
            this.Col_MailAddress.ReadOnly = true;
            this.Col_MailAddress.Width = 200;
            // 
            // Col_Password
            // 
            this.Col_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Password.HeaderText = "パスワード";
            this.Col_Password.Name = "Col_Password";
            this.Col_Password.ReadOnly = true;
            this.Col_Password.Width = 200;
            // 
            // Col_URL
            // 
            this.Col_URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_URL.HeaderText = "URL";
            this.Col_URL.Name = "Col_URL";
            this.Col_URL.ReadOnly = true;
            this.Col_URL.Width = 200;
            // 
            // Col_Remarks
            // 
            this.Col_Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Remarks.HeaderText = "備考";
            this.Col_Remarks.Name = "Col_Remarks";
            this.Col_Remarks.ReadOnly = true;
            this.Col_Remarks.Width = 220;
            // 
            // Col_SortNumber
            // 
            this.Col_SortNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_SortNumber.HeaderText = "ソートNo";
            this.Col_SortNumber.Name = "Col_SortNumber";
            this.Col_SortNumber.ReadOnly = true;
            // 
            // TxtSearchWord
            // 
            this.TxtSearchWord.AnimateReadOnly = false;
            this.TxtSearchWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtSearchWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtSearchWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtSearchWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtSearchWord.Depth = 0;
            this.TxtSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchWord.HideSelection = true;
            this.TxtSearchWord.LeadingIcon = null;
            this.TxtSearchWord.Location = new System.Drawing.Point(6, 6);
            this.TxtSearchWord.MaxLength = 32767;
            this.TxtSearchWord.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.TxtSearchWord.Name = "TxtSearchWord";
            this.TxtSearchWord.PasswordChar = '\0';
            this.TxtSearchWord.PrefixSuffixText = null;
            this.TxtSearchWord.ReadOnly = false;
            this.TxtSearchWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtSearchWord.SelectedText = "";
            this.TxtSearchWord.SelectionLength = 0;
            this.TxtSearchWord.SelectionStart = 0;
            this.TxtSearchWord.ShortcutsEnabled = true;
            this.TxtSearchWord.Size = new System.Drawing.Size(412, 48);
            this.TxtSearchWord.TabIndex = 1;
            this.TxtSearchWord.TabStop = false;
            this.TxtSearchWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSearchWord.TrailingIcon = null;
            this.TxtSearchWord.UseSystemPasswordChar = false;
            this.TxtSearchWord.TextChanged += new System.EventHandler(this.TxtSearchWord_TextChanged);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1388, 627);
            this.materialTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.BtnKeyUpdate);
            this.tabPage1.Controls.Add(this.BtnKeyAdd);
            this.tabPage1.Controls.Add(this.TxtSearchWord);
            this.tabPage1.Controls.Add(this.TableKeyData);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            // 
            // BtnKeyUpdate
            // 
            this.BtnKeyUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKeyUpdate.AutoSize = false;
            this.BtnKeyUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnKeyUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnKeyUpdate.Depth = 0;
            this.BtnKeyUpdate.HighEmphasis = true;
            this.BtnKeyUpdate.Icon = null;
            this.BtnKeyUpdate.Location = new System.Drawing.Point(1248, 9);
            this.BtnKeyUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnKeyUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.BtnKeyUpdate.Name = "BtnKeyUpdate";
            this.BtnKeyUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnKeyUpdate.Size = new System.Drawing.Size(125, 36);
            this.BtnKeyUpdate.TabIndex = 3;
            this.BtnKeyUpdate.Text = "更新";
            this.BtnKeyUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnKeyUpdate.UseAccentColor = false;
            this.BtnKeyUpdate.UseVisualStyleBackColor = true;
            this.BtnKeyUpdate.Click += new System.EventHandler(this.BtnKeyUpdate_Click);
            // 
            // BtnKeyAdd
            // 
            this.BtnKeyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKeyAdd.AutoSize = false;
            this.BtnKeyAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnKeyAdd.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnKeyAdd.Depth = 0;
            this.BtnKeyAdd.HighEmphasis = true;
            this.BtnKeyAdd.Icon = null;
            this.BtnKeyAdd.Location = new System.Drawing.Point(1115, 9);
            this.BtnKeyAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnKeyAdd.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.BtnKeyAdd.Name = "BtnKeyAdd";
            this.BtnKeyAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnKeyAdd.Size = new System.Drawing.Size(125, 36);
            this.BtnKeyAdd.TabIndex = 2;
            this.BtnKeyAdd.Text = "追加";
            this.BtnKeyAdd.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnKeyAdd.UseAccentColor = false;
            this.BtnKeyAdd.UseVisualStyleBackColor = true;
            this.BtnKeyAdd.Click += new System.EventHandler(this.BtnKeyAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainForm";
            this.PrimaryColor = MaterialSkin2DotNet.Primary.Indigo700;
            this.PrimaryDarkColor = MaterialSkin2DotNet.Primary.Indigo400;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableKeyData)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialDataTable TableKeyData;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 TxtSearchWord;
        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnKeyAdd;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnKeyUpdate;
        private DataGridViewTextBoxColumn Col_ID;
        private DataGridViewTextBoxColumn Col_Name;
        private DataGridViewTextBoxColumn Col_LoginID;
        private DataGridViewTextBoxColumn Col_MailAddress;
        private DataGridViewTextBoxColumn Col_Password;
        private DataGridViewTextBoxColumn Col_URL;
        private DataGridViewTextBoxColumn Col_Remarks;
        private DataGridViewTextBoxColumn Col_SortNumber;
    }
}