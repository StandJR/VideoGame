namespace VideoGame;

abstract class Weapon
{
    public AttackInfo AttackInfo { get; protected set; } = null!;
    public string? Name { get; protected set; }
    public int Weight { get; protected set; }
    public abstract void Attack(ref Player enemy);
}