using System;

namespace Arrays_as_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //CHALLANGE

            int[] happiness = new int[] { 1, 3, 5, 7, 9};
            GetHappiness(happiness);  
            
            foreach (int finalValue in happiness)
            {
                Console.WriteLine("Increased happiness: {0}", finalValue);
                
            }
            Console.ReadKey();

            int[] studentGrages = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentGrages);

            foreach (int grade in studentGrages)
            {
                Console.WriteLine("{0}", studentGrages);
            }

            Console.WriteLine("The average is: {0}", averageResult);
            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void GetHappiness(int[] happiness)
            {
                

                for (int i = 0; i < happiness.Length; i++)
                {
                    happiness[i] += 2;
                }
               
            }               
        }
    }

