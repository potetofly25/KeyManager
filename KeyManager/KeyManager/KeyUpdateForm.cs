using KeyManager.Dao;
using KeyManager.Models;
using MaterialSkin2DotNet.Controls;

namespace KeyManager
{
    public partial class KeyUpdateForm : MaterialForm
    {
        public KeyItem? TargetItem { get; set; }

        public KeyUpdateForm()
        {
            InitializeComponent();
        }

        private void KeyUpdateForm_Load(object sender, EventArgs e)
        {
            ShowItem();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            KeyItem? item = GetInput();
            if (item == null)
                return;

            KeyDao.Update(item);
            //Clear();
            UpdateList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TargetItem == null)
                return;

            KeyDao.Delete(TargetItem);
            Clear();
            UpdateList();
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowItem()
        {
            Clear();
            if (TargetItem == null)
                return;

            if (TargetItem.Name != null)
                TxtName.Text = TargetItem.Name;
            if (TargetItem.LoginId != null)
                TxtLoginId.Text = TargetItem.LoginId;
            if (TargetItem.MailAddress != null)
                TxtMailAddress.Text = TargetItem.MailAddress;
            if (TargetItem.LoginPassword != null)
                TxtPassword.Text = TargetItem.LoginPassword;
            if (TargetItem.Url != null)
                TxtUrl.Text = TargetItem.Url;
            if (TargetItem.Remarks != null)
                TxtRemarks.Text = TargetItem.Remarks;
            if (TargetItem.SortNumber != null)
                TxtSortNumber.Text = TargetItem.SortNumber.ToString();
        }

        private KeyItem? GetInput()
        {
            if (TargetItem == null)
                return null;

            KeyItem item = new KeyItem();

            item.Id = TargetItem.Id;

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
