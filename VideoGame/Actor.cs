namespace VideoGame;

abstract class Actor : IStatusApplyable
{
    protected ConsoleLogger _logger = new ConsoleLogger();
    public virtual int Health { get; protected set; } = 100;
    public virtual bool IsAlive { get; protected set; } = true;
    public virtual Point2D Coordinates { get; set; } = new Point2D(0, 0);
    public virtual Status? Status { get; protected set; }
    public void ApplyStatus(Actor enemy, Status? status)
    {
        if (status == null)
        {
            _logger.Log(LogLevel.Warning, "Null Exception");
        }
        enemy.Status = status;
    }
}

