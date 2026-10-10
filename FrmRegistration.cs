using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextFileApp
{
    public partial class frmRegistration : Form
    {
        private string _ContactNo;
        private string _FullName;
        private int _Age;

        public frmRegistration()
        {
            InitializeComponent();
        }

        public string ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = Contact;
            }

            else throw new FormatException();

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            else throw new FormatException();

            return _Age;
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }

        private void clearFields()
        {
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtLastName.Clear();
            cbGender.SelectedIndex = -1;
            cbPrograms.SelectedIndex = -1;
            datePickerBirthday.Text = "";
            txtAge.Clear();
            txtContactNo.Clear();
            txtStudentNo.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool valid = true;

            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtMiddleInitial.Text == "" ||
                    txtStudentNo.Text == "" || txtContactNo.Text == "" || txtAge.Text == "")
                throw new ArgumentNullException();

                string outtext = "  -- Student Information --  \n\n";

                outtext += "Student Number: " + txtStudentNo.Text + "\n";
                outtext += "Full Name: " + FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text) + "\n";
                outtext += "Program: " + cbPrograms.Text + "\n";
                outtext += "Age: " + Age(txtAge.Text).ToString() + "\n";
                outtext += "Birthday: " + datePickerBirthday.Value.ToString("yyyy-MM-dd") + "\n";
                outtext += "Contact Number: " + ContactNo(txtContactNo.Text).ToString() + "\n";

                string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
                string.Concat(txtStudentNo.Text, ".txt"))))
                {
                    MessageBox.Show("Registry File Created for Student: " + txtStudentNo.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    outputFile.WriteLine(outtext);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid input, please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (valid)
            {
                clearFields();
            }
        }
    }
}
