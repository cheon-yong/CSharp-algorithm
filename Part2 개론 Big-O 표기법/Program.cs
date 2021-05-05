using System;

namespace 개론_Big_O_표기법
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 두 알고리즘 A와 B를 비교할 때 
             * A가 B보다 조금(또는 많이) 빨라요와 같은 표현은 모호하고
             * 프로그램으로 실행 속도를 비교하는 것도 환경에 의존적
             * 입력이 적은 구간과 많은 구간에서 성능이 차이나는 경우도 존재
             * 이러한 것을 해결하기 위해 Big-O 표기법을 사용
             * 
             * BIG-O 표기법 1단계
             * 수행되는 연산(산술, 비교 대입 등)의 개수를 대략적으로 판단
             * ex)
             * int Add(int N)
             * {
             *      return N + N;
             * }
             * 
             * 1
             * 
             * int Add2(int N)
             * {
             * for (int i = 0; i < N; i++)
             * {
             *   sum += i;
             * }
             * return sum;
             * }
             * n + 1
             * 
             * BIG-O 표기법 2단계
             * 영향력이 가장 큰 대표 항목만 남기고 삭제
             * 상수는 무시 (2N => N)
             * 
             * O(1 + N + 4 * N^2 + 1)
             * = O(4N^2)
             * = O(N^2)
             * 
             * 
             * 
             * BIG-O 표기법의 의의
             * 
             * O(n^2), O(NlogN), O(n), O(logN), O(1) 등이 있으며
             * 나열된 순서대로 오래걸리고 데이터의 수가 커질수록 그 차이는 점점 더
             * 증가하게 된다
             * 
             */
        }
    }
}
