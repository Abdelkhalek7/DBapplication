using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class addpatient : Form
    {
        Controller controllerObj;
        public addpatient()
        {
            InitializeComponent();




            //  controllerObj = new Controller();
            // DataTable dt = controllerObj.SelectDepNum();
            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "Dnumber";






            //DataTable sn = controllerObj.Selectssn();
            //comboBox2.DataSource = sn;
            //comboBox2.DisplayMember = "SSN";
            /* int num;
                bool s = Int32.TryParse( textBox4.Text,out num);
                if (!s)
                {
                    MessageBox.Show("should be int");
                    return;
                }
             * 
             * if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")//validation part
             * 
             * 
     {
         MessageBox.Show("Please, insert all values");
     }
     else
     {
         controllerObj = new Controller();

         int r = controllerObj.Insertdeprtment(textBox1.Text, int.Parse(textBox4.Text), int.Parse(textBox3.Text), dateTimePicker1.Value);

         if (r == 0)
         {
             MessageBox.Show("The insertion of a new department failed");
         }
         else
         {
             MessageBox.Show("department location inserted successfully");
         }
     }*/



        }



        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usernameerrror.Visible = false;
            if (passwordtext1.Text!=passwordtxt2.Text)
            {
                passworderror.Visible = true;
                return;
            }
            passworderror.Visible = false;


            if (fnametxt.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your frist name");
                return;

            }
            if (midldenametxt.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your middle name name");
                return;

            }
            if (lastnametext.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your last name name");
                return;
            }

            if (passwordtext1.Text=="")//validation part
            {
                MessageBox.Show("Please, insert your password");
                return;
            }

            if ( username.Text == "")//validation part
            {
                MessageBox.Show("Please, insert your username");
                return;
            }
            
                String st = "";

                if (femalradiobutton.Checked == true)
                { st = "F"; }
                else if (malerdiobutton.Checked == true)
                    st = "M";
                else
                    return;
                controllerObj = new Controller();
                int r=0;
                 r = controllerObj.Insertpatient(fnametxt.Text, midldenametxt.Text, lastnametext.Text, int.Parse(ssn.Text), dateofbirth.Value, st,int.Parse(phonenumber.Text), username.Text, phonenumber.Text);

                if (r == 0)
                {
                   // MessageBox.Show("The insertion of a new department failed");
                    usernameerrror.Visible = true;
                }
                else
                {
                    MessageBox.Show("department location inserted successfully");
                }
            
        }

        private void midldenametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bookappointmint f = new bookappointmint();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rate r = new rate();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform m = new mainform();
            m.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();

        }
    }
}


