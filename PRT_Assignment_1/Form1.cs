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
                if (rdoBubbleSort.Checked)//...Bubble Sort Algorithm is also chosen
                {
                    int index = method.LinearSearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else if (index != -2)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Wrong number entered. Please enter numerical value"; //if there's an exception error
                    }
                }
                else if (rdoInsertionSort.Checked)//...Insertion Sort Algorithm is also chosen
                {
                    int index = method.LinearSearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else if (index != -2)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Wrong number entered. Please enter numerical value"; //if there's an exception error
                    }
                }
                else if (rdoQuickSort.Checked)//... Quick Sort Algorithm is also chosen
                {
                    int index = method.LinearSearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else if (index != -2)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Wrong number entered. Please enter numerical value"; //if there's an exception error
                    }
                }
            }

            else if (rdoBinarySearch.Checked) //if the user chooses the Binary Search Algorithm and...
            {
                if (rdoBubbleSort.Checked)//...Bubble Sort Algorithm is also chosen
                {
                    int index = method.BinarySearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else if (index != -2)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Wrong number entered. Please enter numerical value"; //if there's an exception error
                    }
                }
                else if (rdoInsertionSort.Checked)//...Insertion Sort Algorithm is also chosen
                {
                    int index = method.BinarySearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else if (index != -2)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Wrong number entered. Please enter numerical value"; //if there's an exception error
                    }
                }
                else if (rdoQuickSort.Checked)//... Quick Sort Algorithm is also chosen
                {
                    int index = method.BinarySearch(array, txtNumToFind.Text);//Search for the number using Linear Search Algorithm and return an index
                    if (index == -1)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was not found in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else if (index != -2)
                    {
                        lblErrorMsg.Text = $"The number {txtNumToFind.Text} was found at index {index} of Linear Search in the following array: ";
                        lstDisplay.Items.Clear();
                        foreach (var numbers in array)
                        {
                            lstDisplay.Items.Add(numbers);
                        }
                    }
                    else
                    {
                        lblErrorMsg.Text = "Wrong number entered. Please enter numerical value"; //if there's an exception error
                    }
                }
            }

            

        }

        private void txtNumToFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";

        }



    }
}
