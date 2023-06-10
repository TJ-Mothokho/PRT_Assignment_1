using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT_Assignment_1
{
    public partial class Form1 : Form
    {
        Methods method = new Methods();
        int lowerNum = 1, MaxNum = 102;
        public Form1()
        {
            InitializeComponent();
            MaximizeForm();
        }

        private void MaximizeForm()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int NumbertoFind = GetTheNumber("What is the Number you are Looking for? ", lowerNum, MaxNum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vs
        }

    }
}
