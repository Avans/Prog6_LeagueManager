namespace LeagueManager.Domain
{
    public interface IChampion
    {
        string Name { get; }

        string Fight(IChampion champion);
    }
}
