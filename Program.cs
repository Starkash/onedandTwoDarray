namespace OneD
{
    class Array1d
    {
        static void Main()
        {
            int[,,] Arr = new int[3, 1, 4] { { { 0, 4, 8, 10 } }, { { 5, 6, 45, 5 } }, { { 5, 58, 95, 5 } } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write(Arr[i, j, k] + " ");
                        Console.WriteLine();
                    }
                }
                
            }
            Console.ReadLine();

                    


                
        }
    }
}








