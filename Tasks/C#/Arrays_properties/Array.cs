using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Array
    {
        private int[] arr;
        private int size;

        public Array()
        {
            this.size = 5;
            this.arr = new int[size];
        }

        public Array(int size = 0)
        {
            this.size = size;
            this.arr = new int[this.size];
        }

        public int SIZE
        {
            get
            {
                return this.size;
            }
            set
            {
                int[] arr = this.arr;
                this.arr = new int[value];
                for(int i = 0; i < this.size && i < this.arr.Length; i++)
                {
                    this.arr[i] = arr[i];
                }
                this.size = value;
            }
        }

        public int[] ARR
        {
            get
            {
                return this.arr;
            }
            set
            {
                for(int i = 0; i < this.size && i < value.Length; i++)
                {
                    this.arr[i] = value[i];
                }
            }
        }

        public int this[int index]
        {
            get
            {
                if(index > size)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.arr[index];
            }
            set
            {
                if (index > size)
                {
                    throw new IndexOutOfRangeException();
                }
                this.arr[index] = value;
            }
        }
    }
}
