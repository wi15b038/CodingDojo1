using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T> 
    {

        private StackObject<T> pointer;

        public void Push(T element)
        {
            if (element == null)
            {

            }
            else
            {
                if (pointer == null)
                {
                    pointer = new StackObject<T>() { Content = element, Below = null };
                }
                else
                {
                    StackObject<T> temp = new StackObject<T> { Content = element, Below = pointer };
                    pointer = temp;
                }
            }
        }

        public T Pop()
        {
            if(pointer == null)
            {
                throw new Exception();
            }
            else
            {
                T temp = pointer.Content;
                pointer = pointer.Below;
                return temp;
            }
        }


        public T Peek()
        {
            if(pointer == null)
            {
                return default(T);
            }
            else
            {
                return pointer.Content;
            }
            
        }

    }
}
