using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace BrawijayaWorkshop.Win32App
{
    public static class XtraMessageBoxHelper
    {
        public static void ShowWarning(this object sender, string message)
        {
            XtraMessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInformation(this object sender, string message)
        {
            XtraMessageBox.Show(message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(this object sender, string message)
        {
            XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowConfirmation(this object sender, string message)
        {
            return XtraMessageBox.Show(message, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
