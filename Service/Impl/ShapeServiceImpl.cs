namespace BaninProject.Service.Impl;

public class ShapeServiceImpl : ShapeService
{
    public void PyramidA(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }

    public void PyramidB(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }

    public void PyramidC(int n)
    {
        int count = 0;
        bool isForward = true;
        for (int i = 0; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (isForward)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                Console.Write(count);
                if (count == n)
                {
                    isForward = false;
                }
                else if (count == 1)
                {
                    isForward = true;
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    public void SquareD(int n)
    {
        int count = 0;
        int oddGap = 1;
        int evenGap = 2 * n - 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j == 1)
                {
                    count = i;
                }
                else if (j % 2 == 0)
                {
                    count += evenGap;
                }
                else
                {
                    count += oddGap;
                }

                Console.Write((count).ToString().PadRight(3));
            }

            evenGap -= 2;
            oddGap += 2;
            Console.WriteLine();
        }
    }
}