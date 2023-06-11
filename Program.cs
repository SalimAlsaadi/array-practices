namespace arr_practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            
           
           


            int[] arr2 = { 2, 10, 1, 7, 12 };

            int max=0;
            int oddNum = 0;
            int evenNum = 0;
            int secondLargest = 0;

            int sum = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                sum = sum + arr2[i];

            }

            for (int i = 0; i< arr2.Length; i++)
            {
                if (arr2[i] >= max)
                {
                    max = arr2[i];
                }


                if (arr2[i] % 2 == 0)
                {
                    evenNum++;
                }

                else
                {
                    oddNum++;
                }

                for(int x= 0; x<arr2.Length; x++)
                {
                    if (arr2[x]>secondLargest && arr2[x] < max)
                    {
                        secondLargest = arr2[x];
                    }

                }


            }

            Console.WriteLine("the final result of sum of array value is " + sum);
            Console.WriteLine("the max value of this array is " + max);
            Console.WriteLine("the odd numbers equal " + oddNum);
            Console.WriteLine("the even numbers equal " + evenNum);
            Console.WriteLine("second largest number is " + secondLargest);


        }
    }
}