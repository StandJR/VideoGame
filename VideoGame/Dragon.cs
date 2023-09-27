namespace VideoGame;

class Dragon : Actor, IFlyable, IMoveable
{
    public void Fly(DirectionY direction)
    {
        if (direction == DirectionY.Up)
        {
            Coordinates.Y += 5;
        }
        else
        {
            Coordinates.Y -= 5;
        }
    }
    public void Move(DirectionX direction)
    {
        if (direction == DirectionX.Forward)
        {
            Coordinates.X += 5;
        }
        else
        {
            Coordinates.X -= 5;
        }
    }
}
