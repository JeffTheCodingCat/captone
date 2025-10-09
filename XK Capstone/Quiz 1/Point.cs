class Point
{
    int x, y;
    string color;
    public Point(int ex, int why, string col)
    {
        x = ex;
        y = why;
        color = col;
    }
    public Point()
    {
        x = 0;
        y = 0;
        color = "black";
    }
    public override string ToString()
    {
        return $"({x}, {y}) {color}";
    }
    public void move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
    public bool isInQuadrant(int quadrant)
    {
        int quad = 0;
        if (x == 0 && y == 0) { return false; }
        if (x >= 0 && y >= 0) { quad = 1; }
        if (x >= 0 && y < 0) { quad = 3; }
        if (x < 0 && y >= 0) { quad = 2; }
        if (x < 0 && y < 0) { quad = 4; }
        return quad == quadrant;
    }
    public string getColor()
    {
        return color;
    }
    public double distance(Point p2)
    {
        return Math.Sqrt(Math.Pow((p2.x - x), 2) + Math.Pow((p2.y - y), 2));
    }
}