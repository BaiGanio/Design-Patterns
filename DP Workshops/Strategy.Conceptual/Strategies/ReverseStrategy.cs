﻿using System.Collections.Generic;

namespace Strategy.Conceptual
{
    class ReverseStrategy : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
