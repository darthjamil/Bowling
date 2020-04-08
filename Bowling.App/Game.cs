
namespace Bowling.App
{
    public class Game
    {
        private const int PERFECT_ROLL_SCORE = 10;

        private readonly int[] Rolls = new int[21];
        private int CurrentFrame = 0;

        public void Roll(int pins)
        {
            Rolls[CurrentFrame] = pins;
            CurrentFrame++;
        }

        public int GetScore()
        {
            int score = 0;
            int currentRoll = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(currentRoll))
                {
                    score += GetScoreForStrike(currentRoll);
                    currentRoll += 1;
                }
                else if (IsSpare(currentRoll))
                {
                    score += GetScoreForSpare(currentRoll);
                    currentRoll += 2;
                }
                else
                {
                    score += GetScoreForRoll(currentRoll);
                    currentRoll += 2;
                }
            }

            return score;
        }

        private int GetScoreForRoll(int i)
        {
            return Rolls[i] + Rolls[i + 1];
        }

        private int GetScoreForSpare(int i)
        {
            return PERFECT_ROLL_SCORE + Rolls[i + 2];
        }

        private int GetScoreForStrike(int i)
        {
            return PERFECT_ROLL_SCORE + Rolls[i + 1] + Rolls[i + 2];
        }

        private bool IsStrike(int i)
        {
            return Rolls[i] == PERFECT_ROLL_SCORE;
        }

        private bool IsSpare(int i)
        {
            return Rolls[i] + Rolls[i + 1] == PERFECT_ROLL_SCORE;
        }
    }
}
