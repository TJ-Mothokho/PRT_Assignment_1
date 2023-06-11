using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
