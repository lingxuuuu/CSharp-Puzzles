using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            TossMultipleCoins(20);
            Names();
        }

        //Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray()
        {
            //Place 10 random integer values between 5-25 into the array
            Random rand = new Random();
            int[] Output = new int[10];

            //Print the min and max values of the array
            int Min = Output[0];
            int Max = Output[0];
            int Sum = 0;

            for (int i = 0; i < Output.Length; i++)
            {
                Output[i] = rand.Next(5, 25); //place random num into list

                Sum = Sum + Output[i]; // Sum+=Output[i]

                if (Output[i] >= Max)
                {
                    Max = Output[i];
                }
                else if (Output[i] <= Min)
                {
                    Min = Output[i];
                }
            }
            Console.WriteLine($"Min: {Min}, Max: {Max}, Sum: {Sum}");
            return Output;
        }
        public static string TossCoin()
        {
            //Have the function print "Tossing a Coin!"
            Console.WriteLine("Tossing a coin");
            //Randomize a coin toss with a result signaling either side of the coin 
            string result = "";
            Random rand = new Random();
            if (rand.Next(10) <= 5)
            {
                result = "Head";
            }
            else
            {
                result = "Tail";
            }
            Console.WriteLine("result");
            return result; //does not work??????
        }
         public static double TossMultipleCoins(int num)
         {
            int count = 0;
            int heads = 0;
            Random rand = new Random();
            while(count < num)
            {
                if(rand.Next(10) < 5)
                {
                    heads++;
                }
                count++;
            }
            double perc = (double)heads/(double)count;
            Console.WriteLine(perc);
            return perc;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random random = new Random();
            string temp = "";
            for(int i = 0; i < names.Count; i++)
            {
                int rand = random.Next(0,names.Count);
                temp = names[rand];
                names[rand] = names[i];
                names[i] = temp;
            }
            for( int j = 0; j < names.Count; j++)
            {
                if(names[j].Length < 5)
                {
                    names.RemoveAt(j);
                }
                Console.Write(names[j]+ ", ");
            }
            Console.WriteLine();
            return names;
        }
    }
}
