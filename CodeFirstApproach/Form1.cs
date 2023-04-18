using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstApproach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            int rollNumber = int.Parse(txtrollnumber.Text);
            string name = txtname.Text;
            string gender = txtgender.Text;
            string email = txtemail.Text;
            string conemail = txtconfirmemail.Text;

            Student s = new Student()
            {
                RollNumber = rollNumber,
                Name = name,
                Gender = gender,
                Email = email,
                confirmEmail = conemail,
                City = "Pune",
                Fees = 40000

            };
            StudentDbContext db = new StudentDbContext();
            db.students.Add(s);
            db.SaveChanges();
            lblmeassage.Text = "student created successfully";

        }
    }
}
