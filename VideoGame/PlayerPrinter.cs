namespace VideoGame;

static class PlayerPrinter
{
    public static void PrintPlayer(Player player)
    {
        Console.WriteLine($"Health - {player.Health}");
        Console.WriteLine($"Alive - {player.IsAlive}");
        Console.WriteLine($"X - {player.Coordinates.X}");
        Console.WriteLine($"Y - {player.Coordinates.Y}");
        PrintBuffs(player);
        PrintDebuffs(player);
    }
    public static void PrintBuffs(Player player)
    {
        Console.WriteLine("Buffs :");
        foreach (var buff in player.Buffs)
        {
            Console.WriteLine('\t' + buff.ToString());
        }
    }
    public static void PrintDebuffs(Player player)
    {
        Console.WriteLine("Debuffs :");
        foreach (var debuff in player.Debuffs)
        {
            Console.WriteLine('\t' + debuff.ToString());
        }
    }
}