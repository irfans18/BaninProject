namespace BaninProject.Service.Impl;

public class OkYesServiceImpl : OkYesService
{
    public void GenerateOkYes(int n)
    {
        const int OK = 3;
        const int YES = 4;

        for (int i = 1; i <= n; i++)
        {
            if (i % OK == 0 && i % YES == 0)
            {
                Console.Write("OKYES ");
            }
            else if (i % OK == 0)
            {
                Console.Write("OK ");
            }
            else if (i % YES == 0)
            {
                Console.Write("YES ");
            }
            else
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
    }
}