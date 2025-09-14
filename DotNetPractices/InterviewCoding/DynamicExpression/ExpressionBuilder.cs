namespace InterviewCoding.DynamicExpression
{
    public class ExpressionBuilder
    {
        //public Expression<Func<RankInfoBySponsor, bool>> ClauseForNoOfRanks(RankCategory rankCategory, int noOfRank)
        //{


        //    switch (rankCategory)
        //    {
        //        case RankCategory.RedStar:
        //            break;
        //        case RankCategory.GreenStar:
        //            break;
        //        case RankCategory.BlueStar:
        //            break;
        //        case RankCategory.WhiteStar:
        //            break;
        //        case RankCategory.BlackStar:
        //            break;
        //        case RankCategory.GoldStar:
        //            break;
        //        case RankCategory.Mercury:
        //            break;
        //        case RankCategory.Venus:
        //            break;
        //        case RankCategory.Jupiter:
        //            break;
        //        case RankCategory.Phoenix:
        //            break;
        //        case RankCategory.GoldenPhoenix:
        //            return r => r.Phoenix >= noOfRank || r.GoldenPhoenix >= noOfRank || r.DiamondPhoenix >= noOfRank || r.AlphaCentauriClub >= noOfRank;
        //        case RankCategory.DiamondPhoenix:
        //            return r => r.Phoenix >= noOfRank || r.GoldenPhoenix >= noOfRank || r.DiamondPhoenix >= noOfRank || r.AlphaCentauriClub >= noOfRank;
        //        case RankCategory.AlphaCentauriClub:
        //        default:
        //            return null;
        //    }
        //}

        private static bool IsNeglectable(RankCategory rankCategory)
        {
            return rankCategory == RankCategory.AlphaCentauriClub
                            || rankCategory == RankCategory.AdminCNEXChange
                            || rankCategory == RankCategory.AdminEazme
                            || rankCategory == RankCategory.AdminRiseoo
                            || rankCategory == RankCategory.NRIRAP
                            || rankCategory == RankCategory.IRAP;
        }
    }
}
