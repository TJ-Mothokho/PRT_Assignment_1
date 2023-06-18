using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT_Assignment_1
{
    //Group members:
    //s225258358 Tshiamo Mothokho
    //s225866161 Odwa Sithonga
    //s225065002 Brilliant Motjiang

    public partial class Form1 : Form
    {
        Methods method = new Methods();//create a methods object
        int lowerNum = 1, maxNum = 102;
        
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
            int[] array = method.Read(); //Fill the array with data in the txt file
            
            lblErrorMsg.Text = method.GetTheNumber(txtNumToFind.Text, lowerNum, maxNum); // displays an Error if an invalid number is entered

            if (rdoLinearSearch.Checked) //if the user chooses the Linear Search Algorithm and...
            {
                int index = method.LinearSearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                if (index == -1)
                {
                    NotFound(array);
                }
                else if (index != -2)
                {
                    Found(array, index);
                }
                else
                {
                    Invalid(); //if there's an exception error
                }
            }

            else if (rdoBinarySearch.Checked) //if the user chooses the Binary Search Algorithm and...
            {
                if (rdoBubbleSort.Checked)//...Bubble Sort Algorithm is also chosen
                {
                    //Bubble Sort Method should start at line 58
                    method.BubbleSort(array);

                    int index = method.BinarySearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        NotFound(array);
                    }
                    else if (index != -2)
                    {
                        Found(array, index);
                    }
                    else
                    {
                        Invalid();//if there's an exception error
                    }
                }
                else if (rdoInsertionSort.Checked)//...Insertion Sort Algorithm is also chosen
                {
                    //Insertion Sort Method should start at line 77
                    method.InsertionSort(array);

                    int index = method.BinarySearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        NotFound(array);
                    }
                    else if (index != -2)
                    {
                        Found(array, index);
                    }
                    else
                    {
                        Invalid(); //if there's an exception error
                    }
                }
                else if (rdoQuickSort.Checked)//... Quick Sort Algorithm is also chosen
                {
                    //Quick Sort Method should start at line 96
                    method.QuickSort(array, 0, array.Length - 1);

                    int index = method.BinarySearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        NotFound(array);
                    }
                    else if (index != -2)
                    {
                        Found(array, index);
                    }
                    else
                    {
                        Invalid(); //if there's an exception error
                    }
                }
            }

            

        }

        private void txtNumToFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoLinearSearch_CheckedChanged(object sender, EventArgs e)
        {
            grbSort.Enabled = false; //Disable the ability to choose the Sort Algorithm if the user chooses Linear Search
        }

        private void rdoBinarySearch_CheckedChanged(object sender, EventArgs e)
        {
            grbSort.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";

        }
        public void NotFound(int[] array) //If the number is not found in the array
        {
            lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
            lstDisplay.Items.Clear();
            foreach (var numbers in array)
            {
                lstDisplay.Items.Add(numbers);
            }
        }
        public void Found(int[] array, int index)//If the number is found in the array
        {
           if (rdoBinarySearch.Checked)
            {
                lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Binary Search in the following array: ";
                lstDisplay.Items.Clear();
                foreach (var numbers in array)
                {
                    lstDisplay.Items.Add(numbers);
                }
            }
           else if (rdoLinearSearch.Checked)
            {
            lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
            lstDisplay.Items.Clear();
            foreach (var numbers in array)
            {
                lstDisplay.Items.Add(numbers);
            }
        }
        public void Invalid() //if there's an exception error
        {
            lblErrorMsg.Text = "Wrong number entered. Please enter numerical value";
        }


    }
}
