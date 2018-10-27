using System;
using System.Collections.Generic;

namespace Classes_exercises
{
    public class Stack
    {
        private readonly List<object> _objects = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("No object to push to stack");

            _objects.Add(obj);
        }

        public object Pop()
        {
            if (_objects.Count == 0)
                throw new InvalidOperationException("Cannot pop an empty stack");

            var index = _objects.Count - 1;
            object lastElement = _objects[index];
            _objects.RemoveAt(index);
            return lastElement;
        }

        public void Clear()
        {
            _objects.Clear(); 
        }
    }
}