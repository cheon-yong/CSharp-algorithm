using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace 트리_우선순위_큐_마무리
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        List<T> _heap = new List<T>();


        //  O(Log(n))
        public void Push(T data)
        {
            // 힙의 맨 끝에 새로운 데이터를 삽입한다.
            _heap.Add(data);

            // 데이터를 올린다
            int now = _heap.Count - 1;
            while (now > 0)
            {
                int next = (now - 1) / 2;
                if (_heap[now].CompareTo(_heap[next]) < 0)
                    break;

                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;
            }
        }

        // O(log(n))
        public T Pop()
        {
            // 반환할 데이터 
            T ret = _heap[0];

            // 마지막 데이터를 루트로 이동
            int lastIndex = _heap.Count - 1;
            _heap[0] = _heap[lastIndex];
            _heap.RemoveAt(lastIndex);
            lastIndex--;

            // 역으로 내려감
            int now = 0;
            while (true)
            {
                int left = 2 * now + 1;
                int right = 2 * now + 2;

                int next = now;
                //왼쪽값이 현재값보다 크면 왼쪽으로 이동
                if (left <= lastIndex && _heap[next].CompareTo(_heap[left]) < 0)
                    next = left;
                //오른값이 현재값보다 크면 오른쪽으로 이동
                if (right <= lastIndex && _heap[next].CompareTo(_heap[right]) < 0) 
                    next = right;

                if (next == now)
                    break;

                // 두 값을 교체
                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;
            }

            return ret;
        }

        public int Count()
        {
            return _heap.Count;
        }
    }

    class Knight : IComparable<Knight>
    {
        public int Id { get; set; }

        public int CompareTo(Knight other)
        {
            if (Id == other.Id)
                return 0;
            return Id > other.Id ? 1 : -1; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            PriorityQueue<Knight> q = new PriorityQueue<Knight>();
            q.Push(new Knight() { Id = 20 });
            q.Push(new Knight() { Id = 30 });
            q.Push(new Knight() { Id = 40 });
            q.Push(new Knight() { Id = 10 });
            q.Push(new Knight() { Id = 05 });
          

            /*
            PriorityQueue<int> q = new PriorityQueue<int>();
            q.Push(20);
            q.Push(30);
            q.Push(40);
            q.Push(10);
            q.Push(05);
            */
            while (q.Count() > 0)
            {
                Console.WriteLine(q.Pop().Id);
            }
        }
    }
}
