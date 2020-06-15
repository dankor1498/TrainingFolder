using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class TreeEnumerator<T> : IEnumerator<T> where T : IComparable<T>
    {
        private STACK.Stack<T> currentData = null;

        public TreeEnumerator(STACK.Stack<T> data)
        {
            this.currentData = data;
        }

        T IEnumerator<T>.Current
        {
            get
            {
                return currentData.Pop();
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if (currentData.Count == 0)
                return false;
            return true;
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
