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
    }
}
