namespace VideoGame;

interface IUserRepository
{
    public bool Add(User user);
    public bool Remove(string login);
    public User? GetUser(string login);
}