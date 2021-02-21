using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace ArrayStack
{
    class Stack
    {
        private int maxStack;
        public int stackPointer;
        private object[] stack;
        private Stack()
        {
            this.stackPointer = -1;
        }
        public Stack(int sizeStack) : this()
        {
            this.maxStack = sizeStack;
            this.stack = new object[this.maxStack];
        }
        public void Clear()
        {
            this.stackPointer = -1;
            this.stack = new object[this.maxStack];
        }
        private bool IsEmpty()
        {
            if (this.stackPointer == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsFull()
        {
            if (this.stackPointer == (this.maxStack - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Push(object item)
        {
            if (IsFull())
            {
                throw new Exception("StackOverlflowException");
            }
            else
            {
                this.stack[++this.stackPointer] = item;
                return true;
            }
        }
        public object Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("StackUnderflowException");
            }
            else
            {
                var item = this.stack[this.stackPointer];
                this.stack[this.stackPointer] = null;
                this.stackPointer--;
                return item;
            }
        }
    }
}
