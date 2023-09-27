namespace VideoGame;

sealed class Sword : Melee
{
    public Sword(AttackInfo info, int weight, string name = nameof(Sword))
    {
        AttackInfo = info;
        Weight = weight;
        Name = name;
    }
    public override void Attack(ref Player enemy)
    {
        enemy -= AttackInfo.DamagePerSecond;
        if (Random.Shared.Next(0, 10) % 2 == 0)
        {
            enemy.AddDebuff(Debuff.ReducedHealth);
        }
    }
    public override void Swing(AttackInfo info)
    {
        throw new NotImplementedException();
    }
}