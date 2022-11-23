namespace KursALX.Lessons.M2.L1
{
    public class L1Array
    {
        public static void Run()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int[] intArray2 = new int[5];
            ShowArray(intArray);
            ShowArray(intArray2);

            int[,] intMatrix = new int[3, 2];
        }

        public static void Run1()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";
            ShowArray(shoppingArray);
            shoppingArray[0] = "butter";
            ShowArray(shoppingArray);            
            shoppingArray[0] = "apple juice";
            ShowArray(shoppingArray);           
        }

        public static void Run2()
        {
            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix2 = new int[3, 2];
            int[,] intMatrix3 = { { 1, 2, 3 }, { 3, 4, 7 }, { 1, 1, 1 }, { 2, 3, 5 } };

            Show2DArray(intMatrix3);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements : {array.Length}");
            foreach (string item in array)
            { 
                Console.WriteLine(item);
            }
        }

        public static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Show2DArray(int[,] matrix)
        {
            for (int iterator = 0; iterator < matrix.GetLength(0); iterator++)
            {
                for (int iterator1 = 0; iterator1 < matrix.GetLength(1); iterator1++)
                {
                    Console.Write($"{matrix[iterator, iterator1]}");
                }
                Console.WriteLine();
            }
        }
    }
}