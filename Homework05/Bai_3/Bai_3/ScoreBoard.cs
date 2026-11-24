using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    public class ScoreBoard
    {
        public int Score { get; private set; } = 0;

        public event Action<int>? ScoreChanged;

        public void AddScore(int points)
        {
            if (points <= 0) return;
            Score += points;
            ScoreChanged?.Invoke(Score);
        }
    }
}
