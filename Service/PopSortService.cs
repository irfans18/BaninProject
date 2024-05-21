namespace BaninProject.Service;

public interface PopSortService
{
    int[] Pop(int n, int[] numbers);
    int[] Sort(int[] numbers);
    void Display(int[] numbers);
}