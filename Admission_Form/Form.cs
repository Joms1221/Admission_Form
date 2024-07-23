using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
namespace Admission_Form
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var List = new List();
            List.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Counter = (File.ReadAllText("studentsid.txt"));
            int counterint = (Convert.ToInt32(Counter));
            counterint++;
            int students = counterint;
            string FirstName = firstName.Text;
            string lastname = surName.Text;
            string middlename = middleInitial.Text;
            string birthDate = birthDay.Value.ToString("yyyy-MM-dd");
            string gender = male.Checked ? "Male" : "Female";
            string number = contactNumber.Text;
            string Address = address.Text;
            string zipcode = zipCode.Text;
            string contact = contactNumber.Text;
            string Guardian = guardianName.Text;
            string gcontact = guardianContact.Text;
            string grelationship = guardianRelationship.Text;
            string email = emailAddress.Text;

            File.AppendAllText($"studentsid.txt ", students + Environment.NewLine);
            string studentdata = $"{FirstName} , {lastname} , {middlename} , {birthDate} , {gender} , {number},{email},{Address},{Guardian},{gcontact},{grelationship}, {zipcode} , {contact}";
            File.AppendAllText("student_data.txt", studentdata + Environment.NewLine);
            string basicInfo = $"{students},{FirstName+ middlename + lastname }, {number},{Guardian}, {Address},{zipcode},{birthDate}";
            File.AppendAllText("Students_Data.txt", basicInfo + Environment.NewLine);
            MessageBox.Show("Saved Successfully");


            File.Delete("studentsid.txt");
            File.AppendAllText($"studentsid.txt", Convert.ToString(counterint));
        }
    }
}
