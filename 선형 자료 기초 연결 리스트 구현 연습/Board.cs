using System;
using System.Collections.Generic;
using System.Text;

namespace 선형_자료_기초_연결_리스트_구현_연습
{
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next;
        public MyLinkedListNode<T> Prev;
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> Head = null;
        public MyLinkedListNode<T> Tail = null;
        public int Count = 0;
        

        // O(1)
        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            //만약 방이 없었다면 새로 추가한 방이 Head
            if (Head == null)
                Head = newRoom;

            //기존의 마지막 방과 새로 추가되는 방을 연결
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            //새로 추가되는 방을 마지막 방으로 인정
            Tail = newRoom;
            Count++;

            return newRoom;
        }

        // O(1)
        public void Remove(MyLinkedListNode<T> room)
        {
            // 기존의 첫번째 방의 다음 방을 첫번째 방으로 인정
            if (Head == room)
                Head = Head.Next;

            // 마지막 방 이전 방을 마지막 방으로 인정
            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    class Board
    {
        public int[] _data = new int[25]; // 배열
        public MyLinkedList<int> _data3 = new MyLinkedList<int>(); // 연결 리스트

        // 동적배열 연결리스트 구현은 매우 기초
        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }

}
