namespace Y10_Challenge_Kaprikars_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kaprekar's Constant is 6174
            //1. take a 4 digit start number using at least two different digits...e.g. 9218
            //2. order the digits descending 4321, then ascending to get two 4 digit numbers (add leading zeros if needed)
            //3. subtract smaller number from bigger number e.g. 9821-1289=8532
            //4. Go back to step 2 replacing start number with result of step 3, repeat until numbers converge to 6174

            //Task: Write a program to compute Kaprekar's constant using any four digit start number
            //Ext: Display the number of iterations needed until 6174 is reached

            Console.WriteLine("Hello, Type a four digit number:"); //starter code for students
            int x = Convert.ToInt32(Console.ReadLine()); //starter for students
                                                         //YOUR CODE GOES HERE....  
            int[] arr = { 2, 1, 4, 5, 3 };

        }

        private static double[] BubbleSortAscending(double[] numberArray)
        {
            int arrayLength = numberArray.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                for (int j = 0; j < arrayLength - 1 - i; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        double num = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = num;
                    }
                }
            }
            return numberArray;
        }
        public static int ReorderInt32Digits(int v)
        {
            int n = Math.Abs(v);
            int l = ((int)Math.Log10(n > 0 ? n : 1)) + 1;
            int[] d = new int[l];
            for (int i = 0; i < l; i++)
            {
                d[(l - i) - 1] = n % 10;
                n /= 10;
            }
            if (v < 0)
                d[0] *= -1;
            Array.Sort(d);
            Array.Reverse(d);
            int h = 0;

            for (int i = 0; i < d.Length; i++)
            {
                int index = d.Length - i - 1;
                h += ((int)Math.Pow(10, index)) * d[i];
            }
            return h; 
        }



    }
    }

