using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Admission_Form
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = passWord.Text;

            if (File.Exists("Students_Data.txt") != true)
            {

                File.WriteAllText("Students_Data.txt", $"StudentID,FullName,PhoneNumber,GuardianName,Address,ZipCode,Birthday,Status" + Environment.NewLine);

            }

            if (File.Exists("studentsID.txt") != true)
            {

                File.WriteAllText("studentsID.txt", $"0");

            }

            if (username == "a" && password == "a")
            {
                MessageBox.Show("Login successful.");
                var List = new List();
                List.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}

