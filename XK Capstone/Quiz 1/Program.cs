namespace Quiz_1;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(10, 20, "blue");
        Point p2 = new Point();
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        p1.move(5, 10);
        Console.WriteLine(p1);
        if (p1.isInQuadrant(2)) { Console.WriteLine("yes"); } else { Console.WriteLine("no"); }
        double dist = p1.distance(p2);
        Console.WriteLine(dist);
        Console.WriteLine(p2.getColor());
        Point[] points = new Point[4];
        points[0] = p1;
        points[3] = p2;
        foreach (Point p in points)
        {
            if (p != null) { Console.WriteLine(p); }
        }
    }
}
