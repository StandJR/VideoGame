namespace VideoGame;

class Skeleton : Actor, IMoveable
{
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
