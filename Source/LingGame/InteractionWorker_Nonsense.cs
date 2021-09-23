using RimWorld;
using Verse;

namespace LingGame
{
    public class InteractionWorker_Nonsense : InteractionWorker
    {
        public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
        {
            if (initiator.story.traits.HasTrait(ZeroTechTraitDefOf.Ling_NoGod_Nonsense))
            {
                return 0.05f;
            }

            return 0f;
        }
    }
}