using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace dsa_project_orignal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\SYED ARHAM ZAHID\\Desktop\\suffixarray.txt";
            string Input = "";
            try
            {
                using (StreamReader SA = new StreamReader(path))
                {
                    Input = SA.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int Len = Input.Length;

            string[] SArray = new string[Len];

            string[] Array = new string[Len];

            int k = 0;
            foreach (char c in Input)
            {
                Array[k] = Input.Substring(k);
                Console.WriteLine(Array[k]);
                k++;
            }

            string Temp;
            for (int i = 0; i < Len; i++)
            {
                for (int j = 0; j < Len - 1; j++)
                {
                    char C1 = Convert.ToChar(Array[j].Substring(0, 1));
                    char C2 = Convert.ToChar(Array[j + 1].Substring(0, 1));
                    if (C1 > C2)
                    {
                        Temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = Temp;
                    }
                }
            }
            for (int i = 0; i < Len; i++)
            {
                for (int j = 0; j < Len - 1; j++)
                {
                    char C1 = Convert.ToChar(Array[j].Substring(0, 1));
                    char C2 = Convert.ToChar(Array[j + 1].Substring(0, 1));
                    if (C1 == C2)
                    {
                        int A = Array[j].Length;
                        int B = Array[j + 1].Length;
                        if (A > B)
                        {
                            Temp = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = Temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            using (StreamWriter SA = new StreamWriter(path))
            {
                for (int i = 0; i < Len; i++)
                {
                    SA.WriteLine(Array[i]);
                }

            }
            Console.ReadLine();
        }
    }
}
