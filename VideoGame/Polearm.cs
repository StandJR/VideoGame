namespace VideoGame;

sealed class Polearm : Melee
{
    public Polearm(AttackInfo info, int weight, string name = nameof(Polearm))
    {
        AttackInfo = info;
        Weight = weight;
        Name = name;
    }
    public override void Attack(ref Player enemy)
    {
        enemy -= AttackInfo.DamagePerSecond;
        if (Random.Shared.Next(1, 20) % 2 == 0)
        {
            enemy.AddDebuff(Debuff.Poisoned);
        }
         
    }
    public override void Swing(AttackInfo info)
    {
        throw new NotImplementedException();
    }
}