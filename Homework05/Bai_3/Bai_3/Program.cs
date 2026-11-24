using System;

namespace Bai_3
{
    class Program 
    {
        static void ShowScore(int score)
        {
            Console.WriteLine("Diem: " + score);
        }

        static void Main()
        {
            ScoreBoard board = new ScoreBoard();

            Action<int> showScore = score => Console.WriteLine("Diem: " + score);

            board.ScoreChanged += showScore;

            board.AddScore(10);
            board.AddScore(0);
            board.AddScore(20);

            board.ScoreChanged -= showScore;

            board.AddScore(5);

            Console.WriteLine("Diem cuoi: " + board.Score);
        }
    }
}