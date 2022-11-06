using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.GotFocus += textBox1_Enter;
            textBox4.GotFocus += textBox2_Enter;
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ABC");
            if (Validator.IsDecimal(textBox3.Text))
            {
                MessageBox.Show("Decimal");
            }else{
                MessageBox.Show("NotDecimal");
            }
            if (Validator.IsEmail(textBox4.Text)) 
            { 
                MessageBox.Show("Email");
            }else{
                MessageBox.Show("NotMail");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ChangeLang.EnglishKeyBoard();
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            ChangeLang.KhmerKeyBoard();
        }
    }
}
