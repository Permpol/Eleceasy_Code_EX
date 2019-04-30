using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_Test_f.Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Code tab 1

        private void textInput1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label_Output1_Click(object sender, EventArgs e)
        {

        }

        private void label_Output2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioMan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            string inputA1 = textInput1.Text;
            string[] result = inputA1.Split(' ');
            
            if (radioMan.Checked == true)
            {
                result[0] = result[0].Replace("นาย", "");
                result[0] = result[0].Insert(0, "ชื่อ : นาย");
            }
            if (radioFemale.Checked == true)
            {
                result[0] = result[0].Replace("นางสาว", "");
                result[0] = result[0].Insert(0, "ชื่อ : นางสาว");
            }
            
            result[1] = result[1].Insert(0, "นามสกุล : ");
            label_Output1.Text = result[0];
            label_Output2.Text = result[1];
        }




        private void Clear_Click(object sender, EventArgs e)
        {
            string clear1 = "ชื่อ : ";
            string clear2 = "นามสกุล : ";
            label_Output1.Text = clear1;
            label_Output2.Text = clear2;

        }

        

        // End Tab 1
        // Code Tab 2

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubmitCh_Click(object sender, EventArgs e)
        {
            string str1 = "คุณได้เลือก" + Environment.NewLine; 
            if (chBox1.Checked == true)
            {
                str1 = str1 + "-อ่านหนังสือ" + Environment.NewLine;
            }
            if (chBox2.Checked == true)
            {
                str1 = str1 + "-ออกกำลังกาย" + Environment.NewLine;
            }
            if (chBox3.Checked == true)
            {
                str1 = str1 + "-เขียนโปรแกรม" + Environment.NewLine;
            }
            MessageBox.Show(str1, "ความสนใจ");
        }



        // End tab 2


    }
}
