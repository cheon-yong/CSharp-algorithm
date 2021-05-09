using System;
using System.Collections.Generic;
using System.Text;

namespace Part2_선형_자료_기초_동적_배열_구현_연습
{
    class MyList<T> 
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count; // 실제로 사용 중인 데이터 수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 수

        
        // O(1);
        // 조건문에 들어가 있는 for문은 무시, 이 경우는 특이케이스
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아 있는지 확인
            if (Count >= Capacity)
            {
                //공간을 늘려서 확보
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }

            // 2. 공간에 데이터를 삽입
            _data[Count] = item;
            Count++;
        }

        // O(1)
        public T this[int index]
        {
            get { return _data[index];  }
            set { _data[index] = value; }
        }

        // O(n)
        // 최악의 경우를 고려하면 n번 반복
        public void RemoveAt(int index)
        {
            // 101 102 103 104 105
            // -> 101 102 104 105 105
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);
            Count--;
        }
    }

    class Board
    {
        public int[] _data = new int[25]; // 배열
        public MyList<int> _data2 = new MyList<int>(); // 동적 배열
        public LinkedList<int> _data3 = new LinkedList<int>(); // 연결 리스트

        // 동적배열 연결리스트 구현은 매우 기초
        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            //103
            int temp = _data2[2];

            //103
            _data2.RemoveAt(2);

        }
    }
}
