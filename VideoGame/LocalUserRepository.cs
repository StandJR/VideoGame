namespace VideoGame;

class LocalUserRepository : IUserRepository
{
    private readonly List<User> _users = new();

    public bool Add(User user)
    {
        if(GetUser(user.Login) == null)
        {
            _users.Add(user);
            return true;
        }
        return false;
    }

    public User? GetUser(string login)
    {
        foreach (var user in _users)
        {
            if(user.Login == login)
            {
                return user;
            }
        }
        return null;
    }

    public bool Remove(string login)
    {
        User? user = GetUser(login);

        if (user != null)
        {
            _users.Remove(user);
            return true;
        }
        return false;
    }
}