using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstUsingDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtcoursename.Text;
            int duration = int.Parse(txtduration.Text);

            Course c = new Course() { CourseName = name, Duration = duration };
            Model1 db = new Model1();
            db.Courses.Add(c);
            db.SaveChanges();
           gridviewcourses.DataSource= db.Courses.ToList();
        
        }
    }
}
