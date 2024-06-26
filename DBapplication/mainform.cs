using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class mainform : Form
    {
        int pssn;
        Controller controllerObj;
        string docname="";
        string depname = "";
        public mainform()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt;
            dt = controllerObj.Selecttopratedoctor();
            dataGridView1.DataSource = dt;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookappointmint f = new bookappointmint(docname,depname);
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                  

            
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                docname = row.Cells["Doctor Name"].Value.ToString();
                depname = row.Cells["specialization"].Value.ToString();

                button1.Enabled = true;

            
        }
    }
}
