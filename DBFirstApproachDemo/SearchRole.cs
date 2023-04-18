using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstApproachDemo
{
    public partial class SearchRole : Form
    {
        public SearchRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roleid = int.Parse(txtroleid.Text);
        
            B20WinDBContext db = new B20WinDBContext();
            SqlParameter rolename = new SqlParameter()
            {
                ParameterName = "@RoleName",
                SqlDbType=SqlDbType.VarChar,
                Size=50,
                Direction=ParameterDirection.Output,
                Value=string.Empty
            };
            ObjectParameter param = new ObjectParameter("rolename",rolename.Value);
           var result= db.usp_GetRoleNameById(roleid,param);
            txtrolename.Text = param.Value.ToString();
        }
    }
}
