using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRT_Assignment_1
{
    internal class Methods
    {
        public int[] Read()
        {
            StreamReader reader = new StreamReader("AssignementData.txt");
            string Num = " ";
            int i = 0;
            int[] arrayNumber = new int[500];


            while ((Num = reader.ReadLine()) != null)
            {
                arrayNumber[i] = Convert.ToInt32(Num);

                i++;

            }
            reader.Close();
            return arrayNumber;
        }

        public string GetTheNumber(string numToFind, int lowerNum, int maxNum)
        {
            bool valid = true;
            string message="";
            try
            {

                int NumbertoFind = int.Parse(numToFind);

                int num = int.Parse(numToFind);
                //Console.Write(prompt);
                //Num = int.Parse(Console.ReadLine());

                if (num < lowerNum || num > maxNum)
                {
                    message = $"Invalid number entered. Number should be between {lowerNum} and {maxNum}";
                    //Console.WriteLine("Invalid number entered. Number should be between {0} and {1}", lower, maxNum);
                    valid = false;
                }
            }
            catch (System.FormatException ex)
            {
                message = "Wrong number entered. Please enter numerical value";
                valid = false;
            }
            return message;
        }

        public int LinearSearch(int[] arrayNumber, string numToFind) //Linear Search Algorithm
        {
            try
            {
                int numberToFind = int.Parse(numToFind);


                int indexFound = -1;
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    if (numberToFind == arrayNumber[i])
                    {
                        indexFound = i;//sets indexfound to whatever index number the value was in
                        i = arrayNumber.Length;// setting i to the max value so we can leave the loop
                    }
                }
                return indexFound;
            }
            catch(SystemException ex)
            {
                return -2;
            }

            
        }

        public int BinarySearch(int[] array, string numToFind)
        {
            try
            {
                int number = int.Parse(numToFind);
                int first, last, middle = 0;
                bool valid;
                int index;
                first = 0;
                last = array.Length - 1;
                valid = false;
                while (valid == false && first <= last)
                {
                    middle = (first + last) / 2;
                    if (number == array[middle])
                    {
                        valid = true;
                    }
                    else
                    {

                        if (number > array[middle])
                            first = middle + 1;
                        else
                            last = middle - 1;
                    }

                }
                if (valid == true)
                    index = middle;
                else
                    index = -1;
                return index;
            }
            catch (SystemException ex)
            {
                return -2;
            }

            
        }
        public void BubbleSort(int[] arrayNumber)
        {
            int n = arrayNumber.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arrayNumber[j] > arrayNumber[j + 1])
                    {
                        Swap(arrayNumber, j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
        public void QuickSort(int[] arrayNumber, int leftNumber, int rightNumber)
        {
            if (leftNumber < rightNumber)
            {
                int pivotIndex = Partition(arrayNumber, leftNumber, rightNumber);
                QuickSort(arrayNumber, leftNumber, pivotIndex - 1);
                QuickSort(arrayNumber, pivotIndex + 1, rightNumber);
            }
        }
        public int Partition(int[] arrayNumber, int leftNumber, int rightNumber)
        {
            int pivot = arrayNumber[rightNumber];
            int i = leftNumber - 1;

            for (int j = leftNumber; j < rightNumber; j++)
            {
                if (arrayNumber[j] <= pivot)
                {
                    i++;
                    Swap(arrayNumber, i, j);
                }
            }

            Swap(arrayNumber, i + 1, rightNumber);
            return i + 1;
        }
        public void Swap(int[] arrayNumber, int i, int j)
        {
            int temp = arrayNumber[i];
            arrayNumber[i] = arrayNumber[j];
            arrayNumber[j] = temp;
        }

        public void InsertionSort(int[] array)
        {
            int n = array.Length;

            //Iterate over the array starting from the second element
            for (int i=1; i<n ;i++)
            {
                int key = array[i];
                int j = i - 1;

                //Move elements of array[0...i-1], that are greater than the key, to one position ahead of their currrent position
                while (j >= 0 && array[j] > key)
                {
                    array[j+1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = key; //Insert the key at the correct position in the sorted part
            }
        }
    }
}
