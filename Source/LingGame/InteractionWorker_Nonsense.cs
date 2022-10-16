using RimWorld;
using Verse;

namespace LingGame;

public class InteractionWorker_Nonsense : InteractionWorker
{
    public override float RandomSelectionWeight(Pawn initiator, Pawn recipient)
    {
        return initiator.story.traits.HasTrait(ZeroTechTraitDefOf.Ling_NoGod_Nonsense) ? 0.05f : 0f;
    }
}