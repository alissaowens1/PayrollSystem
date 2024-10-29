using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            int dep;
            double hours;
            string[] name=new string[2];

            while(double.TryParse(txt_Hours.Text,out hours)==false)
            {
                MessageBox.Show("Numberic Values should be entered for hours. ");
                txt_Hours.Text = "0";
                txt_Hours.Focus();
            }
            if(int.TryParse(txt_Dependents.Text,out dep) == false)
            {
                MessageBox.Show("Dependent default value of 0 is used,");
                txt_Dependents.Text = "0";
                txt_Dependents.Focus();
            }

            name = txt_Name.Text.Split(' ');
            if(name.Length<2)
            {
                txt_Name.Text = "Please enter full name.";
                txt_Name.Focus();
            }
            else
            {
                if(hours>0)
                {
                    Employee anEmployee = new Employee(name[0], name[1], dep, hours);

                }
            }
        }

        private void setVisibility(bool visabilityValue)
        {
            lbl_Gross.Visible = visabilityValue;
            lbl_Soc.Visible = visabilityValue;
            lbl_FedDed.Visible = visabilityValue;
            lbl_Agency.Visible = visabilityValue;
            lbl_Netpay.Visible = visabilityValue;
            txt_Gross.Visible =(visabilityValue);
            txt_Soc.Visible =(visabilityValue);
            txt_Fed.Visible =(visabilityValue);
            txt_agency.Visible =(visabilityValue);
            txt_net.Visible =(visabilityValue);
        }
    }
}
