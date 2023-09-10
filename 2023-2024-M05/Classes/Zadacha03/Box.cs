﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha03
{
    class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {
            var result = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return result;
        }
    }
}
