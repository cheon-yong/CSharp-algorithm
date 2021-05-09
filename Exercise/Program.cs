using System;
using System.Collections.Generic;

namespace Exercise
{

    // 스택 : LIFO  (후입선출)
    // 큐   : FIFO  (선입선출)
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            stack.Push(104);
            stack.Push(105);

            int data = stack.Pop();
            int data2 = stack.Peek();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(101);
            queue.Enqueue(102);
            queue.Enqueue(103);
            queue.Enqueue(104);
            queue.Enqueue(105);

            int data3 = queue.Dequeue();
            int data4 = queue.Peek();

            // 연결리스트를 사용하면 둘을 합친 기능을 사용하다
            // 그러나 스택 큐를 사용하는 이유는 추상적으로 사용할 때 용이하다
            // 프로그래머간 의사소통시에도 스택 또는 큐로 구현할 예정이다
            // 라는 식으로 구현이 가능하다.
            // 또한 리스트와 비교해 보았을 때 훨씬 빠르다는 장점이 있다.
            // 스택, 큐는 게임에서도 유용하게 사용할 수 있다.
            


        }
    }
}
