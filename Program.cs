class Program
{
static void Main()
    {
        int row = GetChun();

        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(KidKumNon(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

static int GetChun()
    {
        while (true)
        {
            Console.Write("ชั้นสามเหลี่ยม: ");
            int row = int.Parse(Console.ReadLine());

            if (row < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
            else
            {
                return row;
            }
        }
    }
static int KidKumNon(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return KidKumNon(row - 1, col - 1) + KidKumNon(row - 1, col);
        }
    }
}
