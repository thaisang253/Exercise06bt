using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Stack
    {
        private String[] buffer;
        private int top;
        public Stack(int size)
        {
            buffer = new String[size];
            top = -1;
        }
        public void Stack()
        {
            buffer =  new string[1000];
            top = -1;
        }

        public void push(String temp)
        {
            buffer[top + 1] = temp;
            top++;
        }

        public String pop()
        {
            String temp = buffer[top];
            top--;
            return temp;

        }

        public String peek()
        {
            return buffer[top];
        }

        public int count()
        {
            return top + 1;
        }

        public void clear()
        {
            top = -1;
        }
    }
}