
using BaninProject.Service;
using BaninProject.Service.Impl;

namespace BaninProject;

class Program
{
    static void Main(string[] args)
    {
        OkYesService okYesService = new OkYesServiceImpl();
        okYesService.GenerateOkYes(15);

        Console.WriteLine();
        ShapeService shapeService = new ShapeServiceImpl();
        shapeService.PyramidA(5);
        shapeService.PyramidB(5);
        shapeService.PyramidC(5);
        shapeService.SquareD(5);

        Console.WriteLine();
        PopSortService popSortService = new PopSortServiceImpl();
        int[] popped = popSortService.Pop(3, new[] { 12, 9, 13, 6, 10, 4, 7, 2 });
        popSortService.Display(popped);
        Console.WriteLine();
        Console.WriteLine();
        int[] sorted = popSortService.Sort(popped);
        popSortService.Display(sorted);
        
    }
}