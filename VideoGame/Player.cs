namespace VideoGame;
class Player : Actor, IMoveable
{
    public string? NickName { get; set; }
    public List<Buff> Buffs { get; private set; } = new List<Buff>();
    public List<Debuff> Debuffs { get; private set; } = new List<Debuff>();

    public static Player operator +(Player player, int value)
    {
        Player player1 = new Player();
        player1.Coordinates = player.Coordinates;
        player1.Health = player.Health;
        player1.IsAlive = player.IsAlive;
        player1.Debuffs = player.Debuffs;
        player1.Buffs = player.Buffs;

        if ((player1.Health + value) > 100)
        {
            player1.Health = 100;
        }
        else
        {
            player1.Health += value;
        }
        return player1;
    }

    public void HealAbility()
    {
        Health += 50;
    }
    public static Player operator -(Player player, int value)
    {
        Player player1 = new Player();
        player1.Coordinates = player.Coordinates;
        player1.Health = player.Health;
        player1.IsAlive = player.IsAlive;
        player1.Debuffs = player.Debuffs;
        player1.Buffs = player.Buffs;

        if ((player1.Health - value) < 0)
        {
            player1.Health = 0;
            player1.IsAlive = false;
        }
        else
        {
            player1.Health -= value;
        }
        return player1;
    }
    public static implicit operator bool(Player player)
    {
        return player.IsAlive;
    }
    public bool AddBuff(Buff buff)
    {
        if (Buffs.Contains(buff))
        {
            return false;
        }
        Buffs.Add(buff);
        return true;
    }
    public bool AddDebuff(Debuff debuff)
    {
        if (Debuffs.Contains(debuff))
        {
            return false;
        }
        Debuffs.Add(debuff);
        return true;
    }
    public bool RemoveDebuff(Debuff debuff)
    {
        if (Debuffs.Contains(debuff))
        {
            return false;
        }
        Debuffs.Remove(debuff);
        return true;

    }
    public bool RemoveBuff(Buff buff)
    {
        if (Buffs.Contains(buff))
        {
            return false;
        }
        Buffs.Remove(buff);
        return true;

    }
    public void Move(DirectionX direction)
    {
        if (direction == DirectionX.Forward)
        {
            Coordinates.X += 10;
        }
        else
        {
            Coordinates.X -= 10;
        }
        //and animation
    }
    public void Attack(Weapon weapon)
    {
        Attacked?.Invoke(this, weapon.AttackInfo);
    }
    public event EventHandler<AttackInfo>? Attacked;
}

