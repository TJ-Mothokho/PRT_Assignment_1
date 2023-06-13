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
        //Group members:
        //s225258358 Tshiamo Mothokho
        //s225866161 Odwa Sithonga
        //s225065002 Brilliant Motjiang


        public int[] Read() //This method reads from the txt file and assigns all the values in an array
        {
            StreamReader reader = new StreamReader("AssignementData.txt");
            string Num = " ";
            int i = 0;
            int[] arrayNumber = new int[500];


            while ((Num = reader.ReadLine()) != null)//this loop is reading information and storing to array
            {
                arrayNumber[i] = Convert.ToInt32(Num);

                i++;

            }
            reader.Close();
            return arrayNumber;
        }

        public string GetTheNumber(string numToFind, int lowerNum, int maxNum)//this method checks if the user input is valid
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
                message = "Wrong number entered. Please enter numerical value"; //return this string if there's a format exception
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

                //index = BinarySearch(arrayNumber, numbertoFind);
                //return index;
                while (valid == false && first <= last)
                {
                    middle = (first + last) / 2;
                    if (number == array[middle])
                    {
                        valid = true; //number is found
                    }
                    else
                    {

                        if (number > array[middle])
                            first = middle + 1;//Search in the right half of the array
                        else
                            last = middle - 1; //Search in the left half of the array
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
                return -2;//if there's a format exception
            }

            
        }
        public void BubbleSort(int[] arrayNumber)
        {
            int n = arrayNumber.Length;
            bool swapped;

            //a FOR loop for iterating through each element
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                //nested FOR loop for comparing adjacent elements
                for (int j = 0; j < n - i - 1; j++)
                {
                    // check if the current element is greater than the next element
                    if (arrayNumber[j] > arrayNumber[j + 1])
                    {
                        Swap(arrayNumber, j, j + 1);
                        swapped = true;
                    }
                }

                //If no element were swapped in the loop, the array is already sorted and we can break out of the loop
                if (!swapped)
                {
                    break;
                }
            }
        }
        public void QuickSort(int[] arrayNumber, int leftNumber, int rightNumber)
        {
            //check if there are two elements to sort in the array
            if (leftNumber < rightNumber)
            {
                //choose a pivot index and call the partition method to partition the array
                int pivotIndex = Partition(arrayNumber, leftNumber, rightNumber);
                //call the Quicksort method recursively sort the elements before and after the pivot index
                QuickSort(arrayNumber, leftNumber, pivotIndex - 1);
                QuickSort(arrayNumber, pivotIndex + 1, rightNumber);
            }
        }
        public int Partition(int[] arrayNumber, int leftNumber, int rightNumber)
        {
            //choose the last element on the right as the pivot
            int pivot = arrayNumber[rightNumber];
            //Initialize the index of the left element
            int i = leftNumber - 1;

            for (int j = leftNumber; j < rightNumber; j++)
            {
                //if the current element is smaller than or equal to the pivot
                if (arrayNumber[j] <= pivot)
                {
                    i++; //increment the index of the left element
                    Swap(arrayNumber, i, j);
                }
            }

            //Swap the pivot index with the element at the next index index after the left element
            Swap(arrayNumber, i + 1, rightNumber);
            //return the index of the pivot index element
            return i + 1;
        }
        public void Swap(int[] arrayNumber, int i, int j)
        {
            //store the value of arrayNumber[i] in a temporary variable
            int temp = arrayNumber[i];
            //Assign the value of arrayNumber[j] to arrayNumber[i]
            arrayNumber[i] = arrayNumber[j];
            //Assign the value stored in the stored in the temporary variable to arrayNumber[j]S
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
