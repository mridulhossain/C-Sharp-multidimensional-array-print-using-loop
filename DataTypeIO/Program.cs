using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {


            //------------------start a array ----------------------

            int[,,] a = new int[10, 11, 12];

            Console.WriteLine(a.Length);           // 1320(total -> 10*11*12)
            Console.WriteLine(a.GetLength(0));     // 10 -> row count
            Console.WriteLine(a.GetLength(1));     // 11 -> inner row array count
            Console.WriteLine(a.GetLength(2));     // 12 -> single element length

            //------------------end a array ----------------------

            int[,,] threeDarray = new int[2, 2, 3]{
                { { 1, 2,0}, {4, 5, 1} },
                { { 7, 8, 2}, {10, 11, 3} }
            };

            // count row of array
            Console.WriteLine(threeDarray.GetLength(0));

            //count how many array inside
            Console.WriteLine(threeDarray.GetLength(1));

            //count how many element of a single array
            Console.WriteLine(threeDarray.GetLength(2));




            for (int i = 0; i < threeDarray.GetLength(0); i++)
            {
                Console.WriteLine("------ printing " + i + " number row ------  \n\n");

                for (int a = 0; a < threeDarray.GetLength(1); a++) 
                {
                    for (int j = 0; j <threeDarray.GetLength(2); j++ ) 
                    {
                        Console.Write(threeDarray[i,a,j] + " ");
                    }

                    Console.WriteLine("\n\n");
                }

                Console.WriteLine("------ end print " + i + " number row ------  \n\n");

            }
            
        }
    }
}
