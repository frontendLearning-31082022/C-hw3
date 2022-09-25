class Task21
{

    public Task21()
    {
        Console.WriteLine("Введите координаты первой точки в формате x, y, z");
        string input = Console.ReadLine();
        Point point1 = new Point(input);

        Console.WriteLine("Введите координаты второй точки в формате x, y, z");
        input = Console.ReadLine();
        Point point2 = new Point(input);

        double result = point1.calculateLenghtTwoPoints(point2);

        Console.WriteLine("Расстояние между точками " + "{0:#.##}", result);

    }


}