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

        static int GetTheNumber(string prompt, int lower, int maxNum)
        {

            int Num = 0;
            bool valid;

            do
            {
                try
                {
                    valid = true;
                    Console.Write(prompt);
                    Num = int.Parse(Console.ReadLine());

                    if (Num < lower || Num > maxNum)
                    {
                        Console.WriteLine("Invalid number entered. Number should be between {0} and {1}", lower, maxNum);
                        valid = false;
                    }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Wrong number entered. Please enter numerical data");
                    valid = false;
                }

            } while (valid == false);
            return Num;

        }
    }
}
