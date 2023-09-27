namespace VideoGame;

record User
{
    public User() { }
    public User(Player player)
    {
        Player = player;
    }
    public string Login { get; set; } = null!; 
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;
    public Player? Player { get; set; }

}