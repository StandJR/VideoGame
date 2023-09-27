namespace VideoGame;

class Team
{
    public string? TeamName { get; set; }
    private int memberNumber;
    public int MemberNumber
    {
        get
        {
            return memberNumber;
        }
        set
        {
            if (value > 0)
            {
                memberNumber = value;
            }
        }
    }
    private List<Player> players = new List<Player>();
    public bool AddMember(Player player)
    {
        if (players.Count <= MemberNumber)
        {
            players.Add(player);
            return true;
        }
        return false;
    }
    public bool RemoveMember(string nickName)
    {
        Player? player = GetMember(nickName);
        if (player != null)
        {
            players.Remove(player);
            return true;
        }
        return false;
    }
    public Player? GetMember(string nickName)
    {
        foreach (Player player in players)
        {
            if (player.NickName == nickName)
            {
                return player;
            }
        }
        return null;
    }
}
