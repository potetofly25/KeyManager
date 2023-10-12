using KeyManager.PasswordCreater;
using MaterialSkin2DotNet.Controls;

namespace KeyManager
{
    public partial class CreatePasswordForm : MaterialForm
    {
        public bool HasPassword { get; private set; } = false;

        public string ResultPassword { get; private set; } = "";

        public CreatePasswordForm()
        {
            InitializeComponent();
        }

        private void FrmCreatePassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //プロパティ取得（使用文字, パスワード長, 生成個数）
            try
            {
                var para = GetParameter();
                var pwdList = Password.Create(para);
                LstPassword.Items.Clear();
                foreach (var item in pwdList)
                {
                    LstPassword.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (LstPassword.Items.Count == 0)
                return;
            if (LstPassword.SelectedItems.Count == 0)
                return;
            var selectPwd = LstPassword.SelectedItems[0].Text;
            ResultPassword = selectPwd;
            HasPassword = true;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RdbCharLenN_CheckedChanged(object sender, EventArgs e)
        {
            TxtCharLen.Enabled = RdbCharLenN.Checked;
        }

        private Parameter GetParameter()
        {
            Parameter p = new Parameter();

            //使用記号
            p.Numbers = ChkNumbers.Checked;  //数字
            p.Uppercase = ChkUppercase.Checked;  //大文字
            p.Lowercase = ChkLowercase.Checked;  //小文字
            p.Symbols = ChkSymbols.Checked;  //記号

            //パスワード長
            if (RdbCharLen8.Checked == true)
            {
                p.CharLen = 8;
            }
            else if (RdbCharLen12.Checked == true)
            {
                p.CharLen = 12;
            }
            else if (RdbCharLen16.Checked == true)
            {
                p.CharLen = 16;
            }
            else if (RdbCharLenN.Checked == true)
            {
                if (!int.TryParse(TxtCharLen.Text, out int charlen))
                {
                    throw new Exception("文字数の数値を入力してください");
                }
                p.CharLen = charlen;
            }

            //生成個数
            if (RdbCount10.Checked == true)
            {
                p.CreateCount = 10;
            }
            else if (RdbCount30.Checked == true)
            {
                p.CreateCount = 30;
            }

            return p;
        }

    }
}
