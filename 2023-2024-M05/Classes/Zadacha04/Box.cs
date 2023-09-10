using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha04
{
    public class Box<T>
    {
        public int Count { get; private set; }

        private List<T> list;

        public Box()
        {
            list = new List<T>();
            this.Count = 0;
        }
        public void Add(T element)
        {
            list.Add(element);
            this.Count++;
        }
        public T Remove()
        {
            var result = list.Last();
            list.Remove(list.Last());
            this.Count--;
            return result;
        }

        public override string ToString()
        {
            string temp = null, type = null;
            foreach (var item in list)
            {
                type = item.GetType().ToString();
                temp += item.ToString();
            };
            return $"{type}: {temp}";

        }
    }
}
