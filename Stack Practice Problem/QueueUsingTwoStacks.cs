using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Practice_Problem
{
    internal class QueueUsingTwoStacks
    {
        Stack<T> s = new Stack<T>();
        Stack<T> s2 = new Stack<T>();

        public void Enqueue(ThreadStaticAttribute item)
        {
            s = Push(item);
        }
        public T Dequeue()
        {
            if(s2.count == 0)
            {
                while (s.Count > 0)
                {
                    s2.Push(s.Pop());
                }
            }
        }

    }
}
