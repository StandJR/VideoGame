namespace VideoGame;

class Ability
{
    public void Use()
    {
        AbilityUsed?.Invoke();
    }

    public event Action? AbilityUsed;
}