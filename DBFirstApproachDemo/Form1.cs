using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstApproachDemo
{
    public partial class Form1 : Form
    {
        B20WinDBContext db;
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
            LoadRoles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            db = new B20WinDBContext();
           
           // Gridusers.DataSource=db.Users.ToList();
            //Gridusers.DataSource=db.Users.Take(1).ToList();
            //hard code insert ==dynamic=create a form=take input from user
            User user = new User()
            {
                UserId = 7,
                Name = "shrikant",
                Email = "s@s.com",
                Password = "12345",
                RegisteredDate = DateTime.Now
            };
            db.Users.Add(user);
            db.SaveChanges();
            Gridusers.DataSource = db.Users.ToList();

        }
        private void LoadRoles()
        {
            gridRoles.DataSource=db.Roles.ToList();
            gridallactiveRoles.DataSource = db.GetActiveRoles().ToList();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DateTime registeredDate =DateTime.Parse( txtsearch.Text);
            B20WinDBContext db = new B20WinDBContext();
            gridFilterview.DataSource = db.GetUserByRegisterDate(registeredDate)?.ToList();
            MessageBox.Show("filter users loaded");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
           
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            //List<DateTime> registeredDate = new List<DateTime>();
            //registeredDate=datelistview.SelectedItems
            //B20WinDBContext db = new B20WinDBContext();
            //gridFilterview.DataSource = db.GetUserByRegisterDate(registeredDate)?.ToList();
            //MessageBox.Show("filter users loaded");
        }
    }
}
