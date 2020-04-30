﻿/**
 * Created by Moon on 8/5/2019
 * This houses various structures to be used by both plugin and panel
 */

namespace BattleSaberShared
{
    public static class SharedConstructs
    {
        public const string Name = "BattleSaber";
        public const string Version = "0.1.2";
        public const int VersionCode = 012;
        public static string Changelog =
            "0.0.1: Begin assembling UI for coordinator panels\n" +
            //Whoops
            "0.1.1: Implemented versioning system\n" + 
            "0.1.2: Fixed song download bug\n";

        public enum BeatmapDifficulty
        {
            Easy,
            Normal,
            Hard,
            Expert,
            ExpertPlus
        }
    }
}
