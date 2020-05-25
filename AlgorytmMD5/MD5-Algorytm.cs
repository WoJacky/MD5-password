using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AlgorytmMD5
{
    public partial class MD5_Algorytm : UserControl
    {
        public MD5_Algorytm()
        {
            InitializeComponent();
        }
        string hash = "WSB-Poznan";
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtValue.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(txtEncrypt.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtDecrypt.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
