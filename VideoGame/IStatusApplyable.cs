namespace VideoGame;

interface IStatusApplyable
{
    void ApplyStatus(Actor enemy, Status? status);
}