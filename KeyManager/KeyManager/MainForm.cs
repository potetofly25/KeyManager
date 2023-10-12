using KeyManager.Dao;
using KeyManager.Models;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using System.Data;

namespace KeyManager
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            //this.TableKeyData.ScrollBars = ScrollBars.Both;
            //this.TableKeyData.BorderStyle = BorderStyle.FixedSingle;
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Col_ID.DataPropertyName = "Id";
            this.Col_Name.DataPropertyName = "Name";
            this.Col_LoginID.DataPropertyName = "LoginId";
            this.Col_MailAddress.DataPropertyName = "MailAddress";
            this.Col_Password.DataPropertyName = "LoginPassword";
            this.Col_URL.DataPropertyName = "Url";
            this.Col_Remarks.DataPropertyName = "Remarks";
            this.Col_SortNumber.DataPropertyName = "SortNumber";

            this.Col_ID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_Name.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_LoginID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_MailAddress.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_Password.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_URL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_Remarks.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Col_SortNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.Col_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_LoginID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_MailAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_URL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_Remarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Col_SortNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            ReloadList();
        }

        private void BtnKeyAdd_Click(object sender, EventArgs e)
        {
            var frm = new KeyAddForm();
            frm.Owner = this;
            frm.Show();
        }

        private void BtnKeyUpdate_Click(object sender, EventArgs e)
        {
            var item = GetCurrentRow();
            if (item != null)
            {
                var frm = new KeyUpdateForm();
                frm.Owner = this;
                frm.TargetItem = item;
                frm.Show();
            }
        }

        private void TxtSearchWord_TextChanged(object sender, EventArgs e)
        {
            ReloadList();
        }

        private KeyItem? GetCurrentRow()
        {
            if (this.TableKeyData.CurrentRow == null)
                return null;
            KeyItem? rowview = ToItem((DataRowView)TableKeyData.CurrentRow.DataBoundItem);
            return rowview;
        }

        private List<KeyItem>? QueryList(List<KeyItem> items)
        {
            if (items == null || items.Count == 0)
                return items;

            if (TxtSearchWord.Text.Trim() != "")
            {
                string word = TxtSearchWord.Text.Trim();
                for (int i = items.Count - 1; i >= 0; i--)
                {
                    var item = items[i];
                    bool find = false;
                    if (item != null)
                    {
                        if (HasWord(item.Name, word))
                            find = true;
                        if (HasWord(item.LoginId, word))
                            find = true;
                        if (HasWord(item.MailAddress, word))
                            find = true;
                        if (HasWord(item.LoginPassword, word))
                            find = true;
                        if (HasWord(item.Url, word))
                            find = true;
                        if (HasWord(item.Remarks, word))
                            find = true;
                    }
                    if (!find)
                    {
                        items.RemoveAt(i);
                    }
                }
            }
            return items;
        }

        public void ReloadList()
        {
            var records = KeyDao.GetAll();
            if (records == null || records.Count() == 0)
            {
                this.TableKeyData.DataSource = null;
            }
            else
            {
                this.TableKeyData.DataSource = ToTable(QueryList(records.OrderBy(n => n.SortNumber).ThenBy(n => n.Name).ToList()));
            }
        }

        private void TableKeyData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable ToTable(List<KeyItem>? keyItems)
        {
            DataTable dt = new DataTable();

            //データカラムの定義
            dt.Columns.Add("Id", typeof(long));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("LoginId", typeof(string));
            dt.Columns.Add("MailAddress", typeof(string));
            dt.Columns.Add("LoginPassword", typeof(string));
            dt.Columns.Add("Url", typeof(string));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("SortNumber", typeof(long));

            //データテーブルにテータを追加
            if (keyItems != null)
            {
                foreach (var item in keyItems)
                {
                    dt.Rows.Add(item.Id, item.Name, item.LoginId, item.MailAddress, item.LoginPassword, item.Url, item.Remarks, item.SortNumber);
                }
            }

            return dt;
        }

        private KeyItem? ToItem(DataRowView row)
        {
            if (row == null)
                return null;

            KeyItem item = new KeyItem
            {
                Id = (long)row["Id"],
                Name = row["Name"] == DBNull.Value ? null : (string)row["Name"],
                LoginId = row["LoginId"] == DBNull.Value ? null : (string)row["LoginId"],
                MailAddress = row["MailAddress"] == DBNull.Value ? null : (string)row["MailAddress"],
                LoginPassword = row["LoginPassword"] == DBNull.Value ? null : (string)row["LoginPassword"],
                Url = row["Url"] == DBNull.Value ? null : (string)row["Url"],
                Remarks = row["Remarks"] == DBNull.Value ? null : (string)row["Remarks"],
                SortNumber = row["SortNumber"] == DBNull.Value ? null : (long)row["SortNumber"]
            };

            return item;
        }


        private static bool HasWord(string? targetString, string searchString)
        {
            if (targetString == null) return false;
            return (targetString.Contains(searchString, StringComparison.OrdinalIgnoreCase));
        }

    }
}
