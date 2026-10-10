using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace TextFileApp
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName { get; set; }

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid file name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetFileName = string.Concat(txtFileName.Text.Trim(), ".txt");

            MessageBox.Show($"File name set to: {SetFileName}", "File Name Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
