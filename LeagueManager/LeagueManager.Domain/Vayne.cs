namespace LeagueManager.Domain
{
    public class Vayne : IChampion
    {

        public string Name => "Vayne";


        public string Fight(IChampion champion)
        {
            //Vayne wint in dit geval altijd.

            switch (champion.Name)
            {
                case "Vayne" : return "Tie";
                default: return Name;
            }
        }
    }
}
