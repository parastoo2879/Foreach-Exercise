namespace ArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
           
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int column = array1.GetLength(0);
            foreach (var item in array1)
            {

                Console.Write($"{item} ");
                count++;

                if (count % column == 0)
                {
                    Console.WriteLine();
                }


            }
        }
    }
}
