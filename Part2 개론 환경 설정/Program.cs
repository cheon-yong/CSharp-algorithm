using System;

namespace Part2_개론_환경_설정
{
    class Program
    {
        static void Main(string[] args)
        {
            // 모든 게임은 입력 -> 로직 -> 렌더링 단계를 거침
            // FPS 프레임 (프레임이 높을수록 게임이 부드럽게 표현됨)
            // 프레임이란 1초에 Loop가 몇번 수행되는지를 의미함
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
