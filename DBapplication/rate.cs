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
    public partial class rate : Form
    {
        int pssn = 66;
        Controller controllerObj;
        public rate()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt;
            dt = controllerObj.Selectdoc(pssn);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox2.Items.Clear();
            comboBox2.Items.Add(5);
            comboBox2.Items.Add(4);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(1);
            comboBox2.Text = "5";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                controllerObj = new Controller();
                int docid = controllerObj.Selectdocid(comboBox1.Text);

                controllerObj.updaterate(int.Parse(comboBox2.Text), docid, pssn);
            

        }
    }
}
