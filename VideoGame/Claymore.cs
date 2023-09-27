namespace VideoGame;

sealed class Claymore : Melee
{
    public Claymore(AttackInfo info, int weight, string name = nameof(Claymore))
    {
        AttackInfo = info;
        Weight = weight;
        Name = name;
    }
    public override void Attack(ref Player enemy)
    {
        enemy -= AttackInfo.DamagePerSecond;
        if (Random.Shared.Next(1, 11) == 3)
        {
            enemy.AddDebuff(Debuff.ReducedMovementSpeed);
        }
    }
    public override void Swing(AttackInfo info)
    {
        throw new NotImplementedException();
    }
}