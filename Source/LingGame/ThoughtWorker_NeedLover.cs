using RimWorld;
using Verse;

namespace LingGame
{
    public class ThoughtWorker_NeedLover : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            switch (p.relations.DirectRelations
                .FindAll(a => a.def == PawnRelationDefOf.Lover || a.def == PawnRelationDefOf.Spouse).Count)
            {
                case 0:
                    return ThoughtState.ActiveAtStage(0);
                case 1:
                    return ThoughtState.ActiveAtStage(1);
                case 2:
                    return ThoughtState.ActiveAtStage(2);
                default:
                    return ThoughtState.ActiveAtStage(3);
            }
        }
    }
}