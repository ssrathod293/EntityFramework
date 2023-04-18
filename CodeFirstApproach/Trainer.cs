using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirstApproach.Models ;

namespace CodeFirstApproach
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
            Load_Trainer();
        }


        public void Load_Trainer()
        {
            StudentDbContext db = new StudentDbContext();
         
            gridtrainer.DataSource = db.trainers.ToList();
            gridtrainer.Columns.Remove("Students");
            lblmasg.Text = "Trainer Loaded from database";
        }
        public void Trainer_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodeFirstApproach.Models.Trainer t = new CodeFirstApproach.Models.Trainer() {

               TrainerName = txttrainernmae.Text,
              Experience= int.Parse(txtexperiance.Text)

            
            };
            StudentDbContext db = new StudentDbContext();
            db.trainers.Add(t);
            db.SaveChanges();
            Load_Trainer();
          
        }
    }
}
