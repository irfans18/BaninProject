namespace BaninProject.Service.Impl;

public class PopSortServiceImpl : PopSortService
{
    public int[] Pop(int n, int[] numbers)
    {
        int count = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % n == 0)
            {
                count++;
                numbers[i] = Int32.MaxValue;
            }
        }

        int[] result = new int[numbers.Length - count];
        int index = 0;
        foreach (int number in numbers)
        {
            if (number == Int32.MaxValue) continue;
            result[index] = number;
            index++;
        }

        return result;
    }

    public int[] Sort(int[] numbers)
    {
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                }
            }
        }

        return numbers;
    }

    public void Display(int[] numbers)
    {
        foreach (int i in numbers)
        {
            Console.Write($"{i} ");
        }
    }
}