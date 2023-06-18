﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha02
{
    public class Search
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i].CompareTo(key) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0;
            int end = elements.Count() - 1;
            while (end >= start)
            {
                int mid = (start + end) / 2;
                if (elements[mid].CompareTo(key) > 0)
                {
                    end = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;

        }

    }
}
