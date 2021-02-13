using System;
using System.Collections.Generic;

namespace FBLA.Scoreboard
{
    [Serializable]

    public class ScoreboardSaveData
    {
        public List<ScoreboardEntryData> highscores = new List<ScoreboardEntryData>();
    }
}
