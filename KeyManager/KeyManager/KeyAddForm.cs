using KeyManager.Dao;
using KeyManager.Models;
using MaterialSkin2DotNet.Controls;

namespace KeyManager
{
    public partial class KeyAddForm : MaterialForm
    {
        public KeyAddForm()
        {
            InitializeComponent();
        }

        private void KeyAddForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            KeyItem item = GetInput();
            if (item == null)
                return;

            KeyDao.Insert(item);

            Clear();
            UpdateList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private KeyItem GetInput()
        {
            KeyItem item = new KeyItem();

            if (TxtName.Text.Trim() != "")
                item.Name = TxtName.Text.Trim();
            if (TxtLoginId.Text.Trim() != "")
                item.LoginId = TxtLoginId.Text.Trim();
            if (TxtMailAddress.Text.Trim() != "")
                item.MailAddress = TxtMailAddress.Text.Trim();
            if (TxtPassword.Text.Trim() != "")
                item.LoginPassword = TxtPassword.Text.Trim();
            if (TxtUrl.Text.Trim() != "")
                item.Url = TxtUrl.Text.Trim();
            if (TxtRemarks.Text.Trim() != "")
                item.Remarks = TxtRemarks.Text.Trim();

            long sortNum = 0;
            if (TxtSortNumber.Text.Trim() == "" || long.TryParse(TxtSortNumber.Text.Trim(), out sortNum))
            {
                item.SortNumber = sortNum;
            }

            return item;
        }

        private void Clear()
        {
            TxtName.Text = "";
            TxtLoginId.Text = "";
            TxtMailAddress.Text = "";
            TxtPassword.Text = "";
            TxtUrl.Text = "";
            TxtRemarks.Text = "";
            TxtSortNumber.Text = "";
        }

        private void UpdateList()
        {
            if (Owner == null)
                return;
            MainForm mainForm = (MainForm)Owner;
            if (mainForm != null)
            {
                mainForm.ReloadList();
            }
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            var frm = new CreatePasswordForm();
            frm.ShowDialog();
            if (frm.HasPassword)
            {
                this.TxtPassword.Text = frm.ResultPassword;
            }
        }

    }
}
