using System;

namespace Part2_선형_자료_기초_동적_배열_구현_연습
{
    class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int lastTick = 0;
            while (true)
            {
                #region 프레임 관리
                int currentTick = System.Environment.TickCount;
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
