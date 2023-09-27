namespace VideoGame;
class Point2D
{
    private int _x;
    private int _y;
    public Point2D()
    {
        X = Y = default;
    }
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X{ get { return _x; }
        set
        {
            _x = value;
        }
    }
    public int Y{ get { return _y; }
        set{
            if (value < 0){
                _y = 0;
            }
            else{
                _y = value;
            }
        }
    }

    public static Point2D operator +(Point2D point1, Point2D point2)
    {
        Point2D point3 = new Point2D();
        point3.X = point1.X + point2.X;
        point3.Y = point1.Y + point2.Y;
        return point3;
    }
    public static Point2D operator -(Point2D point1, Point2D point2)
    {
        Point2D point3 = new Point2D();
        if ((point1.X - point2.X) < 0)
        {
            point3.X = 0;
        }
        else
        {
            point3.X = point1.X - point2.X;
        }
        if ((point1.Y - point2.Y) < 0)
        {
            point3.Y = 0;
        }
        else
        {
            point3.Y = point1.Y - point2.Y;
        }
        return point3;
    }
}