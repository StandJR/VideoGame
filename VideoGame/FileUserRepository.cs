using System.IO;
using System.Text.Json;

namespace VideoGame;


class FileUserRepository : IUserRepository
{
    private List<User> _users;

    public FileUserRepository()
    {
        _users = new();
        using var streamReader = new StreamReader("users.json");
        var json = streamReader.ReadToEnd();
        var read = JsonSerializer.Deserialize<List<User>>(json);
        if(read != null)
        {
            _users = read;
        }
    }
    public bool Add(User user)
    {
        if (GetUser(user.Login) == null)
        {
            _users.Add(user);
            using var streamWriter = new StreamWriter("users.json");
            var json = JsonSerializer.Serialize(_users);
            streamWriter.Write(json);
            streamWriter.Flush();
            return true;
        }
        return false;
    }

    public User? GetUser(string login)
    {
        foreach (var user in _users)
        {
            if (user.Login == login)
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
            using var streamWriter = new StreamWriter("users.json");
            var json = JsonSerializer.Serialize(_users);
            streamWriter.Write(json);
            streamWriter.Flush();
            return true;
        }
        return false;
    }
}