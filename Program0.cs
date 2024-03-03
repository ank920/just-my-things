class Crossptt
{
    static void Main(string[] args)
    {
        int N = 5;
        int count = N * 2 - 1;

        for (int i = 1; i <= count; i++)
        {
            for (int j = 1; j <= count; j++)
            {
                if (j == i || j == count - i + 1)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }


        Console.WriteLine("Created by Ankit Verma ");
        Console.WriteLine("MCA-I A, Roll No: 14");
    }
}

