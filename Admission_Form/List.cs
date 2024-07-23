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
    public partial class List : System.Windows.Forms.Form
    {
        public List()
        {
            InitializeComponent();
            studentsList.ReadOnly = true;
            if (File.Exists("Students_Data.txt"))
            {
                var lines = File.ReadAllLines("Students_Data.txt");
                if (lines.Length > 0)
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var data = lines[i].Split(',');
                       studentsList.Rows.Add(data);
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found: ");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            var Login  = new Login();
            Login.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //later
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Form = new Form();
            Form.Show();
            this.Hide();
        }
    }
}
