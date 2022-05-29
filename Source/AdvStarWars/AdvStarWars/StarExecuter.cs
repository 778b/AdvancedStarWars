using RimWorld;
using Verse;


namespace AdvStarWars
{
    [StaticConstructorOnStartup]
    public static class StarExecuter
    {
        public const string Name = "AdvancedStarWars: ";

        static StarExecuter()
        {
            Verse.Pawn
            Log.Message(Name + "Constructing ...");
        }
        
    }
}
