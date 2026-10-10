using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace TextFileApp
{
    public partial class FrmLab1 : Form
    {
        private string getInput;

        public FrmLab1()
        {
            InitializeComponent();

            frmRegistration reg = new frmRegistration();
            reg.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                getInput = txtInput.Text;
                FrmFileName frmFileName = new FrmFileName();
                frmFileName.ShowDialog();

                string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
                FrmFileName.SetFileName)))
                {
                    MessageBox.Show("File Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
