using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Item<T>
    {
        public T Value { get; set; }
        public Item<T> Pointer { get; set; }
    }

    class Queue<T>
    {
        Item<T> head;
        Item<T> data;
        Item<T> prev;

        public virtual void Enqueue(T value)
        {
            data = new Item<T>() { Value = value };
            if (head == null)
            {
                head = data;
                prev = new Item<T>();
                prev = data;
                return;
            }
            prev.Pointer = data;
            prev = data;
        }

        public bool IsEmpty() => head == null;

        public virtual T Dequeue()
        {
            if(head == null)
            {
                throw new IndexOutOfRangeException();
            }
            T value = head.Value;
            head = head.Pointer;
            return value;
        }

        public virtual IEnumerable<T> PrintQueue()
        {
            Item<T> item = head;
            while(item != null)
            {
                yield return item.Value;
                item = item.Pointer;
            }
        }
    }

    class BankQueue<T>
    {
        public int Teller { get; private set; }
        public int Speed { get; private set; }

        int[] arrivalMins = new int[2];
        int[] duration = new int[2];

        Queue<T> queue = new Queue<T>();

        public BankQueue(int teller, int speed, int[]arrival, int[] duration)
        {
            Teller = teller;
            Speed = speed;
            arrivalMins[0] = arrival[0];
            arrival.CopyTo(arrivalMins, 0);
            duration.CopyTo(this.duration, 0);
        }

        public void StartBankQueue()
        {
            Random random = new Random();
            
            while (true)
            {
                //if (queue.IsEmpty() || )
            }
        }

    }
}
