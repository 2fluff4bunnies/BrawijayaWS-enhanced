using BrawijayaWorkshop.Utils;
using System;
using System.Windows.Forms;

namespace BrawijayaWorkshop.CryptoWin32App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlainText.Text))
            {
                try
                {
                    txtEncryptResult.Text = txtPlainText.Text.Encrypt();
                }
                catch
                {
                    MessageBox.Show(this, "Encryption Failed!", "Error");
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptedText.Text))
            {
                try
                {
                    txtPlainTextResult.Text = txtEncryptedText.Text.Decrypt();
                }
                catch
                {
                    MessageBox.Show(this, "Decryption Failed!", "Error");
                }
            }
        }
    }
}
